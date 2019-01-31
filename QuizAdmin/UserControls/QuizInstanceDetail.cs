﻿using System;
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
    /// <summary>
    /// QuizDetail UserControl
    /// Used to display details of quiz
    /// </summary>
    public partial class QuizInstanceDetail : UserControl
    {
        public QuizInstanceDetail()
        {
            InitializeComponent();
        }

        // Feed with selected/active quiz
        public void InitializeQuizDetail(QuizInstance quizInstance)
        {
            lblTitle.Text = quizInstance.Quiz.Title;
            lblDescription.Text = quizInstance.Quiz.Description;
            lblRunDate.Text = quizInstance.StartDate.ToString("yyyy-MM-dd hh:mm:ss");
        }
    }
}
