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
    /// QuestionView UserControl
    /// Used to show question list, details and create new
    /// </summary>
    public partial class QuestionView : UserControl
    {
        private IRepository repository;
        private Question activeQuestion;


        public QuestionView()
        {
            InitializeComponent();
            InitializeEventHandler();
        }

        // Inject QuizMasterServiceClient dependency, and active user
        public void InjectIRepository(IRepository repository)
        {
            this.repository = repository;
        }

        // Reset on visibility changed
        private void QuestionView_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible && !Disposing && repository != null)
            {
                InitializeQuestionList();
                ShowQuestionDetail();
            }
        }

        #region EventHandlers

        // EventHandlers and method that will handle an event when the event provides data.
        private void InitializeEventHandler()
        {
            this.questionList.OnSelectedQuestionChanged += new EventHandler<Question>(SelectedQuestionChanged);
            this.questionCreate.OnSaveQuestionClick += new EventHandler(SaveQuestion);
            this.questionCreate.OnCancelClick += new EventHandler(CancelQuestionCreate);
        }

      
        #endregion

        #region POST

        // Save new question
        // This will be called whenever OnSaveQuestionClick is invoked
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
                var answer = new Answer() { Text = item.AnswerText};

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
            ShowQuestionDetail();

        }

        private void CancelQuestionCreate(object sender, EventArgs e)
        {
            ShowQuestionDetail();
        }


        #endregion

        #region GET
        // EVENT QuestionView > VisibleChanged
        // Re-initialize list of questions
        private void InitializeQuestionList()
        {
            this.questionList.InitializeQuestionList(repository.Service.GetQuestions());
        }
        // EVENT questionList > OnSelectedQuestionChanged
        // Selected question on list of questions changed
        private void SelectedQuestionChanged(object sender, Question question)
        {
            this.activeQuestion = question;
            InitializeQuestionDetail();
        }
        // Re-initialize question detail, after selected list of questions changed
        private void InitializeQuestionDetail()
        {
            this.questionDetail.InitializeQuestionsDetail(activeQuestion);
        }

        #endregion

        #region CLICKS
        // Show create question user control
        private void btnCreate_Click(object sender, EventArgs e)
        {
            ShowQuestionCreate();
        }

        #endregion

        // Switch visibility on: questionDetail <-> questionCreate

        private void ShowQuestionCreate()
        {
            questionDetail.Hide();
            questionCreate.Show();

            btnCreate.Hide();
            lblToggleHeader.Text = "Opret Spørgsmål";
        }
        private void ShowQuestionDetail()
        {
            questionDetail.Show();
            questionCreate.Hide();

            btnCreate.Show();
            lblToggleHeader.Text = "Detaljer";
        }
    }
}
