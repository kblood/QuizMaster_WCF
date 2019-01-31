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

namespace QuizAdmin.UserControls
{
    public partial class StatisticTable : UserControl
    {
        delegate void InitializeTableCallBack(QuizInstance quizInstance);

        public StatisticTable()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes the table with the data from the QuizInstance
        /// </summary>
        internal void InitializeTable(QuizInstance quizInstance)
        {
            if (this.questionContestantStats.InvokeRequired)
            {
                //A @ is used here to show that we don't mean the keyword
                InitializeTableCallBack @delegate = new InitializeTableCallBack(InitializeTable);
                this.Invoke(@delegate, new Object[] { quizInstance });
            }
            else
            {
                questionContestantStats.Rows.Clear();
                questionContestantStats.Columns.Clear();
                InitializeColoumns(quizInstance);
                InitializeRows(quizInstance);
                questionContestantStats.Refresh();
            }
        }

        /// <summary>
        /// Makes the columns for the table. 
        /// One for each Contestant, as well as one for the QuestionInstances.
        /// </summary>
        public void InitializeColoumns(QuizInstance quizInstance)
        {
            DataGridViewColumn[] columns = new DataGridViewColumn[quizInstance.Contestants.Count + 1];

            columns[0] = new DataGridViewTextBoxColumn();
            columns[0].HeaderText = "Spørgsmål";
            columns[0].ReadOnly = true;

            for (int i = 1; i < columns.Length; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = quizInstance.Contestants[i - 1].Name;
                column.ReadOnly = true;
                columns[i] = column;
            }
            this.questionContestantStats.Columns.AddRange(columns);
        }

        /// <summary>
        /// Populates the table with the data from the QuizInstance
        /// </summary>
        public void InitializeRows(QuizInstance quizInstance)
        {
            questionContestantStats.Rows.Add();
            for (int i = 0; i < quizInstance.QuestionInstances.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)questionContestantStats.Rows[0].Clone();
                QuestionInstance questionInstance = quizInstance.QuestionInstances[i];
                row.Cells[0].Value = questionInstance.Header;
                int i2 = 0, i3 = 1;
                foreach (Contestant contestant in quizInstance.Contestants)
                {
                    if (questionInstance.WrongAnswers.Count > i2 && questionInstance.WrongAnswers[i2].Id.Equals(contestant.Id))
                    {
                        row.Cells[i3].Value = "✕";
                        i2++;
                    }
                    else if (questionInstance.CorrectAnswer != null && questionInstance.CorrectAnswer.Id.Equals(contestant.Id))
                    {
                        row.Cells[i3].Value = "✓";
                    }
                    else
                    {
                        row.Cells[i3].Value = "◯";
                    }
                    i3++;
                }
                questionContestantStats.Rows.Add(row);
            }
            questionContestantStats.Rows.RemoveAt(0);
        }
    }
}
