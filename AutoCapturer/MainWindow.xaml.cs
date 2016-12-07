using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using System.Windows.Media.Animation;

namespace AutoCapturer
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {

        DoubleAnimation da = new DoubleAnimation();
        DoubleAnimation da2 = new DoubleAnimation();

        public MainWindow()
        {
            InitializeComponent();




            da.From = -this.Width;
            da2.From = -this.Height;

            da.To = 0;
            da2.To = 0;


            da.AccelerationRatio = 1;
            da.Duration = new Duration(TimeSpan.FromMilliseconds(800));
            //애니메이션 효과를 적용한 후에는 속성 값을 변경하기
            da.FillBehavior = FillBehavior.Stop;

            da2.AccelerationRatio = 0;
            da2.Duration = new Duration(TimeSpan.FromMilliseconds(800));
            //애니메이션 효과를 적용한 후에는 속성 값을 변경하기
            da2.FillBehavior = FillBehavior.Stop;


            da.EasingFunction = new CircleEase();
            da2.EasingFunction = new CircleEase();


            this.BeginAnimation(Window.LeftProperty, da);
            this.BeginAnimation(Window.TopProperty, da2);






            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://localhost:52899/");

            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            ////TODO : 이 부분에 발생한 오류 처리
            //var str = new string[] { "uutak2000", "uutkk" };

            //MediaTypeFormatter frmter = new JsonMediaTypeFormatter();

            //HttpContent cont = new ObjectContent<string[]>(str, frmter);

            //var resp = client.PostAsync("api/world/Create", cont).Result;



            //// 모든 제품들의 목록.
            //HttpResponseMessage response = client.GetAsync("api/world/name").Result;  // 호출 블록킹!
            //if (response.IsSuccessStatusCode)
            //{
            //    // 응답 본문 파싱. 블록킹!
            //    var products = response.Content.ReadAsAsync<string>().Result;
            //    MessageBox.Show(products);

            //}
            //else
            //{
            //    MessageBox.Show($"{(int)response.StatusCode} ({response.ReasonPhrase})");
            //}


        }

        private void BtnEnAutoSave_Click(object sender, RoutedEventArgs e)
        {
            da.To = -this.Width;
            da2.To = -this.Height;

            da.From = 0;
            da2.From = 0;

            da.AccelerationRatio = 1;
            da2.AccelerationRatio = 1;

            this.BeginAnimation(Window.LeftProperty, da);
            this.BeginAnimation(Window.TopProperty, da2);
        }

        private void BtnAllCapture_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"POP.wav");
            player.Play();
        }

        private void BtnSelCapture_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
