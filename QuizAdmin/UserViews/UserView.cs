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
    /// UserView UserControl
    /// Used to login and create new user
    /// </summary>
    /// <remarks> 
    /// Invokes SetActiveUser event after successful login
    /// </remarks>
    public partial class UserView : UserControl
    {
        private IRepository repository;

        // Event declaration using generic EventHandler<T> event type
        public event EventHandler<User> SetActiveUser;

        public UserView()
        {
            InitializeComponent();

            // Add event handlers and event-invoking method
            userLogin.UserLoginClick += new EventHandler(OnUserLogin);
            userCreate.UserCreateClick += new EventHandler(OnUserCreate);

            userLogin.ToggleView += new EventHandler(ToggleUserControls);
            userCreate.ToggleView += new EventHandler(ToggleUserControls);
        }

        public void InjectIRepository(IRepository repository)
        {
            this.repository = repository;
        }

        // Reset; Called when visibility on this control i changed
        private void UserView_VisibleChanged(object sender, EventArgs e)
        {
            userCreate.Hide();
            userLogin.Show();
            lblOutput.Text = "";
        }

        // User created; userCreate.UserCreateClick
        private void OnUserCreate(object sender, EventArgs e)
        {
            char[] chars = new char[] { ' ' };
            if (repository.Service.InsertUser(userCreate.Username.TrimStart(chars).TrimEnd(chars), userCreate.Password) > 0)
            {
                userCreate.UserCreated();
                lblOutput.Text = "Bruger blev oprettet";
                ToggleUserControls(sender, e);
            }
            else
            {
                lblOutput.Text = "Bruger blev ikke oprettet. Ugyldigt brugernavn.";
            }
        }

        // User login; userLogin.UserLoginClick
        private void OnUserLogin(object sender, EventArgs e)
        {
            User user = repository.Service.Login(userLogin.Username, userLogin.Password);
            if (user == null)
            {
                userLogin.Output = "Brugernavn eller password er forkert";
            }
            else
            {
                // Invoke the event; main form gets and sets active user
                if (SetActiveUser != null)
                {
                    SetActiveUser(this, user);
                }
            }
        }

        // Toggle control visibility UserLogin <-> UserCreate ToggleView
        private void ToggleUserControls(object sender, EventArgs e)
        {
            if (userCreate.Visible)
            {
                userCreate.Hide();
                userLogin.Show();
            }

            else
            {
                userCreate.Show();
                userLogin.Hide();
            }
        }

    }
}
