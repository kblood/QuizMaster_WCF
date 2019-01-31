using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizAdmin.QuizMasterService;

namespace QuizAdmin.UserViews
{
    /// <summary>
    /// QuizQuestionView UserControl
    /// Used to add question to active quiz
    /// </summary>
    /// <remarks> 
    /// Active quiz is injected by main form
    /// </remarks>
    public partial class QuizQuestionView : UserControl
    {
        private IRepository repository;
        private Quiz activeQuiz;
        public QuizQuestionView()
        {
            InitializeComponent();
            InitializeEventHandler();
        }
        public void InjectIRepository(IRepository repository)
        {
            this.repository = repository;
        }
        // EventHandlers and method that will handle an event when the event provides data.
        private void InitializeEventHandler()
        {
            this.questionCreate.OnSaveQuestionClick += new EventHandler(SaveQuestion);
            this.questionCreate.OnCancelClick += new EventHandler(CancelQuestionCreate);
        }

        // Save new question
        private void SaveQuestion(object sender, EventArgs e)
        {
            // Get new question object from service
            Question question = repository.Service.CreateQuestion();

            // Set question values from questionCreate user control
            question.Header = questionCreate.HeaderText;
            question.Text = questionCreate.QuestionText;

            // Foreach answer-create user controls in questionCreate user control
            foreach (var item in questionCreate.Answers)
            {
                // Set answer value from  answer-create user control
                var answer = new Answer() { Text = item.AnswerText };

                // Add answer to Question list
                question.Answers.Add(answer);

                if (item.CorrectAnswerChecked)
                {
                    // If CorrectAnswer in answer-create user control is checked
                    question.CorrectAnswer = answer;
                }
            }

            //SAVE
            repository.Service.SaveQuestion(question);
            InitializeQuestionList();
            ShowQuestionList();
        }

        // Cancel question create control
        private void CancelQuestionCreate(object sender, EventArgs e)
        {
            ShowQuestionList();
        }

        // Called by main form
        public void SetActiveQuiz(Quiz quiz)
        {
            this.activeQuiz = quiz;
            quizDetail.InitializeQuizDetail(activeQuiz);
            ShowQuestionList();
            InitializeQuestionList();
        }

        // Get list of allQuestions and quizQuestions; 
        private void InitializeQuestionList()
        {
            var allQuestions = repository.Service.GetQuestions();

            List<Question> quizQuestions = repository.Service.GetAllByQuizId(activeQuiz.Id);

            List<Question> availableQuestions = allQuestions.Where(allQuest => !quizQuestions.Any(quizQuest => quizQuest.Id == allQuest.Id)).ToList();

            questionAllList.OnSelectedQuestionChanged += new EventHandler<Question>(SetQuestionDetail);

            questionAllList.InitializeQuestionList(availableQuestions);

            questionQuizList.InitializeQuestionList(quizQuestions);
        }

        private void SetQuestionDetail(object sender, Question question)
        {
            questionsDetails.InitializeQuestionsDetail(question);
 
        }

        // Add  question to quiz
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Question question = questionAllList.GetSelectedItem();
            if (question != null)
            {
                repository.Service.AddQuestion(activeQuiz.Id, question.Id);
            }
            InitializeQuestionList();
        }

        // Remove question from quiz
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Question question = questionQuizList.GetSelectedItem();
            if (question != null)
            {
                repository.Service.RemoveQuestion(activeQuiz.Id, question.Id);
            }
            InitializeQuestionList();
        }

        // Show create question control
        private void btnCreateQuestion_Click(object sender, EventArgs e)
        {
            ShowQuestionCreate();
        }

        // Switch visibility on: questionList <-> questionCreate

        private void ShowQuestionCreate()
        {
            lblSubHeader.Text = "Opret spørgsmål";
            questionAllList.Hide();
            questionsDetails.Hide();
            pnlAddRemoveBtn.Hide();
            btnCreateQuestion.Hide();
            questionCreate.Show();

        }

        private void ShowQuestionList()
        {
            lblSubHeader.Text = "Tilgængelige spørgsmål";
            questionAllList.Show();
            questionsDetails.Show();
            pnlAddRemoveBtn.Show();
            btnCreateQuestion.Show();
            questionCreate.Hide();
        }
    }
}
