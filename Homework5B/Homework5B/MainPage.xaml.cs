using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Homework5B
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private int bakugou = 0;
        private int deko = 0;
        private int todoroki = 0;
        private int tenya = 0;
        private String winner;
        

        private void Dad_good(object sender, EventArgs e)
        {
            deko += 1;
            todoroki += 2;
            FirstQuestion.IsVisible = false;
            SecQuestion.IsVisible = true;
        }

        private void Dad_Bad(object sender, EventArgs e)
        {
            bakugou += 1;
            tenya += 2;
            FirstQuestion.IsVisible = false;
            SecQuestion.IsVisible = true;
        }

        private void RightThnig(object sender, EventArgs e)
        {
            deko += 2;
            todoroki += 1;
            SecQuestion.IsVisible = false;
            ThirdQuestion.IsVisible = true;
        }
 
        private void Fame_and_glory(object sender, EventArgs e)
        {
            tenya += 1;
            bakugou += 2;
            SecQuestion.IsVisible = false;
            ThirdQuestion.IsVisible = true;
        }

        private void capture_the_villain(object sender, EventArgs e)
        {
            tenya += 2;
            deko += 2;
            ThirdQuestion.IsVisible = false;
            ForthQuestion.IsVisible = true;
        }

        private void Kill_the_villain(object sender, EventArgs e)
        {
            todoroki += 1;
            bakugou += 2;
            ThirdQuestion.IsVisible = false;
            ForthQuestion.IsVisible = true;
        }


        private void rival(object sender, EventArgs e)
        {
            todoroki += 1;
            ForthQuestion.IsVisible = false;
            QuestionFive.IsVisible = true;
        }

        private void friend(object sender, EventArgs e)
        {
            bakugou += 1;
            ForthQuestion.IsVisible = false;
            QuestionFive.IsVisible = true;
        }

        private void All_might_is_cool(object sender, EventArgs e)
        {
            todoroki += 1;
            bakugou += 2;
            QuestionFive.IsVisible = false;
            next.IsVisible = true;
        }

        private void All_might_is_not_cool(object sender, EventArgs e)
        {
            deko += 2;
            tenya += 1;
            QuestionFive.IsVisible = false;
            next.IsVisible = true;
        }


        private void submit(object sender, EventArgs e)
        {
            if (deko > bakugou & deko > todoroki & deko > tenya)
            {
                winner = "Deko";
            }
            else if (bakugou > deko & bakugou > todoroki & bakugou > tenya)
            {
                winner = "Bakugou";
            }
            else if (todoroki > deko & todoroki > bakugou & todoroki > tenya)
            {
                winner = "Todoroki";
            }
            else if(tenya > deko & tenya > bakugou & tenya >  todoroki)
            {
                winner = "Tenya";
            }
            else
            {
                winner = "tie";
            }
            
            @out.Text = "you are " + winner;
            next.IsVisible = false;
            rezalt.IsVisible = true;
        }

        private void Reset(object sender, EventArgs e)
        {
            deko = 0;
            todoroki = 0;
            bakugou = 0;
            tenya = 0;
            rezalt.IsVisible = false;
            FirstQuestion.IsVisible = true;
        }
    }
    
}