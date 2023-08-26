using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestHistoryUkraine
{
    public partial class Form1 : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex;
        public int Ball = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeQuestions();//чтобы список вопросов был инициализирован при запуске приложения
            ShowQuestion(currentQuestionIndex);// Отображение первого вопроса
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Если отмечено больше 2 элементов, то снимаем выделение со всех и отмечаем текущий.
            if (checkedListBox1.CheckedItems.Count > 1)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    checkedListBox1.SetItemChecked(i, false);
                checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, true);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //question.Text = "ВОПРОС ВТОРОЙ";
            //label2.Text = $"Баллы: {Ball}";
            
            if (checkedListBox1.SelectedIndex >= 0)
                {
                    Answer selectedAnswer = questions[currentQuestionIndex].Answers[checkedListBox1.SelectedIndex];
                    Ball += selectedAnswer.Score;
                    currentQuestionIndex++;
                    ShowQuestion(currentQuestionIndex);
                progressBar1.PerformStep();
            }
                else
                {
                    MessageBox.Show("Выберите ответ!");
                }
            
            UpdateLabel();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UpdateLabel()//метод по обновлению баллов
        {
            label2.Text = $"Баллы: {Ball}";
        }

        private void InitializeQuestions()//инициализация вопросов
        {
            // Создайте список вопросов с ответами и баллами
            questions = new List<Question>
            {
               //1
                new Question("У результаті Люблінської унії українські землі Подніпров’я, Волині та Східного Поділля переходили під владу", new List<Answer>
                {
                    new Answer("Османської імперії.", 0),
                    new Answer("Московського царства.", 0),
                    new Answer("Польського королівства.", 1),
                    new Answer("Молдавського князівства.",0)

                }),
                //2
                new Question("Де відбулася перша переможна битва козацького війська під час Національно-визвольної війни українського народу проти Речі Посполитої середини ХVІІ ст.?", new List<Answer>
                {
                    new Answer("на Жовтих Водах", 1),
                    new Answer("під Корсунем", 0),
                    new Answer("під Пилявцями.", 0),
                    new Answer("під Зборовим",0)

                }),
                //3
                 new Question("Що було характерним для періоду Руїни?", new List<Answer>
                {
                    new Answer("всеохопна криза та занепад Речі Посполитої, спричинені Національно-визвольною війною українського народу під проводом Б. Хмельницького", 0),
                    new Answer("внутрішня боротьба козацької старшини за владу, розкол Гетьманщини, втручання в її внутрішні справи та військова агресія сусідніх держав", 1),
                    new Answer("форсований наступ на автономні права Гетьманщини царського уряду внаслідок переходу гетьмана І. Мазепи на бік шведського короля", 0),
                    new Answer("остаточна ліквідація інституту гетьманства, решток української автономії та повна інтеграція українських земель у Російську імперію",0)

                }),
                 //4
                 new Question("Укажіть хронологічні межі російсько-турецької війни, результати якої створили передумови для ліквідації Російською імперією Кримського ханства.", new List<Answer>
                {
                    new Answer("1768–1774 рр.", 1),
                    new Answer("1787–1791 рр.", 0),
                    new Answer("1806–1812 рр.", 0),
                    new Answer("1828–1829 рр.",0)

                }),
                 //5
                 new Question("Прочитайте уривок джерела.\r\n\r\n«Давно вони вже відвернулися від тої живої Русі, що говорила, співала, страждала.., а знайшли другу, мертву, той кам’яний істукан – Русь, що виписана була в документах!..»\r\n\r\nПро критику представників якої течії в українському суспільно-політичному русі другої половини ХІХ ст. ідеться?", new List<Answer>
                {
                    new Answer("радикалів", 0),
                    new Answer("народовців", 0),
                    new Answer("громадівців", 0),
                    new Answer("москвофілів",1)

                }),
                 //6

                 new Question("Яка подія є свідченням утисків української мови в Російській імперії в ХІХ ст.?", new List<Answer>
                {
                    new Answer("видання царем Емського указу", 1),
                    new Answer("запровадження латиниці в українському правописі", 0),
                    new Answer("відкриття лише трьох університетів на українських землях", 0),
                    new Answer("закриття Південно-Західного відділення російського географічного товариства",0)

                }),
                 //7
                  new Question("Реалізація імперської стратегії Росії в Першій світовій війні щодо «…злиття землі Ярослава Осмомисла, князів Данила і Романа з Імперією в політичному, соціальному та національному відношеннях…» стала можливою завдяки", new List<Answer>
                {
                    new Answer("Карпатській операції.", 0),
                    new Answer("Горліцькому прориву", 0),
                    new Answer("Брусиловському прориву.", 0),
                    new Answer("Галицькій битві.",1)

                }),
                  //8
                   new Question("У якому уривку з історичного джерела відображено сутність літературної дискусії, започаткованої М. Хвильовим?", new List<Answer>
                {
                    new Answer("«…необхідно відзначити, що Волинська і Київська губернії беруться як приклади найбільш успішного проведення політики українізації, а Донецька – як найбільш відстала в цьому відношенні губернія…»", 0),
                    new Answer("«…кінець малоросійському епігонству і провінційності, українське мистецтво прилучається до світового, і, в першу чергу, до західноєвропейського; Українське мистецтво…започатковує нове велике культурне коло…»", 1),
                    new Answer("«…мені здається, що переклад повісті “Мати” [Максима Горького] на українську говірку не потрібен. Мене дуже дивує той факт, що люди […] прагнуть зробити говірку мовою, пригноблюють тих великоросів, які є меншиною в області цієї говірки…»", 0),
                    new Answer("«…на Україні […] культура міста є російська, а культура села – українська. Поставити собі завдання активно українізувати партію, це значить стати на точку зору нижчої культури села, порівняно з вищою культурою міста…»",0)

                }),
                   //9
                    new Question("«…це один із керівників уніатської Церкви на Західній Україні... що він має ненависть до совєтської влади, і що уніатське духовенство заявляло про необхідність знищити Росію як єдину державу, розділити її на частини та відірвати Україну від Москви… що український народ є давніший від російського, що історія українського народу не має нічого спільного з історією російського народу…» – такі «злочини» інкримінувала радянська влада митрополиту", new List<Answer>
                {
                    new Answer("Андрею Шептицькому.", 0),
                    new Answer("Мирославу Любачівському.", 0),
                    new Answer("Йосипу Сліпому.", 1),
                    new Answer("Любомиру Гузару.",0)

                }),
                    //10
                     new Question("Виникнення в Україні руху «шістдесятників» зумовлено", new List<Answer>
                {
                    new Answer("лібералізацією суспільно-політичного та духовного життя.", 1),
                    new Answer("збільшенням фінансування культури та народної творчості.", 0),
                    new Answer("долученням до європейської та світової культурної спадщини.", 0),
                    new Answer("поверненням в українську культуру забутих і репресованих імен.",0)

                }),
                //     //11
                //      new Question("Конституцію України було ухвалено", new List<Answer>
                //{
                //    new Answer("16 липня 1990 р.", 0),
                //    new Answer("24 серпня 1991 р.", 0),
                //    new Answer("19 липня 1994 р.", 0),
                //    new Answer("28 червня 1996 р.",1)

                //}),

                //       new Question("", new List<Answer>
                //{
                //    new Answer("", 0),
                //    new Answer("", 1),
                //    new Answer("", 0),
                //    new Answer("",0)

                //}),

                
            };
        }

        public class Question
        {
            public string Text { get; set; }
            public List<Answer> Answers { get; set; }

            public Question(string text, List<Answer> answers)
            {
                Text = text;
                Answers = answers;
            }
        }

        public class Answer
        {
            public string Text { get; set; }
            public int Score { get; set; }

            public Answer(string text, int score)
            {
                Text = text;
                Score = score;
            }
        }

        private void ShowQuestion(int questionIndex)
        {
            if (questionIndex < questions.Count)
            {
                Question question = questions[questionIndex];
                questionLabel.Text = question.Text;
                checkedListBox1.Items.Clear();
                foreach (Answer answer in question.Answers)
                {
                    checkedListBox1.Items.Add(answer.Text);
                }
            }
            else
            {
                // Все вопросы пройдены, покажите итоговый балл
                MessageBox.Show($"Тест завершен! Ваш итоговый балл: {Ball}");
                // Можно также сохранить результаты в файл или базу данных
                if(Ball<8)
                MessageBox.Show("Добре, що ти не викладаєш історію...");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Тест завершен! Ваш итоговый балл: {Ball}");

            Application.Exit();
            
        }

      

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
