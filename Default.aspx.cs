using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Input;
using System.Data.SqlClient;
using System.Data;
using System.Text;


namespace WebApplication9
{
    public partial class _Default : Page
    {
        
        

        /*--------------------here---------------------------*/
        protected void Page_Load(object sender, EventArgs e)
        {
            //TextBox9.Text = Convert.ToString("1");
            




           
        }
  

        

        protected void Button4_Click(object sender, EventArgs e)
        {
            //TextBox58.Text = Convert.ToString(float.Parse(TextBox9.Text));
            // 1st row 21.181°N   70.724°E time:09:38:05
            //TextBox58.Text = Convert.ToString(Convert.ToInt64(float.Parse(TextBox9.Text)) * r.Next(1,100));
            Random r9 = new Random(); double d1; d1 = 2.007 + 11 + 6 + 2.1181 + 7.0724 + 9 + 38 + 5; Random rnine = new Random(); Random r92 = new Random(); Random r93 = new Random();
            TextBox9.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox10.Text) + float.Parse(TextBox17.Text) + float.Parse(TextBox16.Text) + (2007 + 11 + 6 + 21.181 + 70.724 + 9 + 38 + 5) / rnine.Next(10,1500)) / r9.Next(1,100)));
            Random r10 = new Random();Random rten = new Random();
            TextBox10.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox11.Text) + float.Parse(TextBox18.Text) + float.Parse(TextBox17.Text) + float.Parse(TextBox16.Text) + float.Parse(TextBox9.Text) + (2006 + 3 + 7 + 21.181 + 70.724 + 9 + 38 + 5) / rten.Next(10,1500))/ r10.Next(1,100)));
            Random r11 = new Random(); Random releven = new Random();
            TextBox11.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox12.Text) + float.Parse(TextBox19.Text) + float.Parse(TextBox18.Text) + float.Parse(TextBox17.Text) + float.Parse(TextBox10.Text) + (2006 + 2 + 14 + 21.181 + 70.724 + 9 + 38 + 5) / releven.Next(10,1500)) / r11.Next(1,100)));
            Random r12 = new Random(); Random rtwelve = new Random();
            TextBox12.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox13.Text) + float.Parse(TextBox20.Text) + float.Parse(TextBox19.Text) + float.Parse(TextBox18.Text) + float.Parse(TextBox11.Text) + (2005 + 12 + 14 + 21.181 + 70.724 + 9 + 38 + 5) / rtwelve.Next(10,1500)) / r12.Next(1,100)));
            Random r13 = new Random();Random rthirteen = new Random();
            TextBox13.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox14.Text) + float.Parse(TextBox21.Text) + float.Parse(TextBox20.Text) + float.Parse(TextBox19.Text) + float.Parse(TextBox12.Text) + (2005 + 3 + 14 + 21.181 + 70.724 + 9 + 38 + 5) / rthirteen.Next(10,1500)) / r13.Next(1,100)));
            Random r14 = new Random();Random rforteen = new Random();
            TextBox14.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox15.Text) + float.Parse(TextBox22.Text) + float.Parse(TextBox21.Text) + float.Parse(TextBox20.Text) + float.Parse(TextBox13.Text) + (1988 + 8 + 6 + 21.181 + 70.724 + 9 + 38 + 5) / rforteen.Next(10,1500)) / r14.Next(1,100)));
            Random r15 = new Random();Random rfifteen = new Random();
            TextBox15.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox22.Text) + float.Parse(TextBox21.Text) + float.Parse(TextBox14.Text) + (1988 + 2 + 6 + 21.181 + 70.724 + 9 + 38 + 5) / rfifteen.Next(10,1500)) / r15.Next(1,100)));
            // 2nd row 23.777°N   70.899°E time:18:20:46 
            Random r16 = new Random(); Random rsixteen = new Random();
            TextBox16.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox9.Text) + float.Parse(TextBox10.Text) + float.Parse(TextBox17.Text) + float.Parse(TextBox24.Text) + float.Parse(TextBox23.Text) + (2007 + 11 + 6 + 23.777 + 70.899 + 18 + 20 + 46) / rsixteen.Next(10,1500)) / r16.Next(1,100)));
            Random r17 = new Random(); Random rseventeen = new Random();
            TextBox17.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox9.Text) + float.Parse(TextBox10.Text) + float.Parse(TextBox11.Text) + float.Parse(TextBox18.Text) + float.Parse(TextBox25.Text) + float.Parse(TextBox24.Text) + float.Parse(TextBox23.Text) + float.Parse(TextBox16.Text) + (2006 + 3 + 7 + 23.777 + 70.899 + 18 + 20 + 46) / rseventeen.Next(10,1500)) / r17.Next(1,100)));
            Random r18 = new Random(); Random reighteen = new Random();
            TextBox18.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox10.Text) + float.Parse(TextBox11.Text) + float.Parse(TextBox12.Text) + float.Parse(TextBox19.Text) + float.Parse(TextBox26.Text) + float.Parse(TextBox25.Text) + float.Parse(TextBox24.Text) + float.Parse(TextBox17.Text) + (2006 + 2 + 14 + 23.777 + 70.899 + 18 + 20 + 46) / reighteen.Next(10,1500)) / r18.Next(1,100)));
            Random r19 = new Random(); Random rnineteen = new Random();
            TextBox19.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox11.Text) + float.Parse(TextBox12.Text) + float.Parse(TextBox13.Text) + float.Parse(TextBox20.Text) + float.Parse(TextBox27.Text) + float.Parse(TextBox26.Text) + float.Parse(TextBox25.Text) + float.Parse(TextBox18.Text) + (2005 + 12 + 14 + 23.777 + 70.899 + 18 + 20 + 46) / rnineteen.Next(10,1500)) / r19.Next(1,100)));
            Random r20 = new Random(); Random rtwenty = new Random();
            TextBox20.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox12.Text) + float.Parse(TextBox13.Text) + float.Parse(TextBox14.Text) + float.Parse(TextBox21.Text) + float.Parse(TextBox28.Text) + float.Parse(TextBox27.Text) + float.Parse(TextBox26.Text) + float.Parse(TextBox19.Text) + (2006 + 3 + 14 + 23.777 + 70.899 + 18 + 20 + 46) / rtwenty.Next(10,1500)) / r20.Next(1,100)));
            Random r21 = new Random(); Random rtwoone = new Random();
            TextBox21.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox13.Text) + float.Parse(TextBox14.Text) + float.Parse(TextBox15.Text) + float.Parse(TextBox22.Text) + float.Parse(TextBox29.Text) + float.Parse(TextBox28.Text) + float.Parse(TextBox27.Text) + float.Parse(TextBox20.Text) + (1988 + 8 + 6 + 23.777 + 70.899 + 18 + 20 + 46) / rtwoone.Next(10,1500)) / r21.Next(1,100)));
            Random r22 = new Random(); Random rtwotwo = new Random();
            TextBox22.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox14.Text) + float.Parse(TextBox15.Text) + float.Parse(TextBox29.Text) + float.Parse(TextBox28.Text) + float.Parse(TextBox21.Text) + (1988 + 2 + 6 + 23.777 + 70.899 + 18 + 20 + 46) / rtwotwo.Next(10,1500)) / r22.Next(1,100)));
            // 3rd row 27.382°N   88.388°E  time: 00:55:25 
            Random r23 = new Random(); Random rtwo3 = new Random();
            TextBox23.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox16.Text) + float.Parse(TextBox17.Text) + float.Parse(TextBox24.Text) + float.Parse(TextBox31.Text) + float.Parse(TextBox30.Text) + (2007 + 11 + 6 + 27.382 + 88.388 + 55 + 25) / rtwo3.Next(10,1500)) / r23.Next(1,100)));
            Random r24 = new Random(); Random rtwo4 = new Random();
            TextBox24.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox16.Text) + float.Parse(TextBox17.Text) + float.Parse(TextBox18.Text) + float.Parse(TextBox25.Text) + float.Parse(TextBox32.Text) + float.Parse(TextBox31.Text) + float.Parse(TextBox30.Text) + float.Parse(TextBox23.Text) + (2006 + 3 + 7 + 27.382 + 88.388 + 55 + 25) / rtwo4.Next(10,1500)) / r24.Next(1,100)));
            Random r25 = new Random(); Random rtwo5 = new Random();
            TextBox25.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox17.Text) + float.Parse(TextBox18.Text) + float.Parse(TextBox19.Text) + float.Parse(TextBox26.Text) + float.Parse(TextBox33.Text) + float.Parse(TextBox32.Text) + float.Parse(TextBox31.Text) + float.Parse(TextBox24.Text) + (2006 + 2 + 14 + 27.382 + 88.388 + 55 + 25) / rtwo5.Next(10,1500)) / r25.Next(1,100)));
            Random r26 = new Random(); Random rtwo6 = new Random();
            TextBox26.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox18.Text) + float.Parse(TextBox19.Text) + float.Parse(TextBox20.Text) + float.Parse(TextBox27.Text) + float.Parse(TextBox34.Text) + float.Parse(TextBox33.Text) + float.Parse(TextBox32.Text) + float.Parse(TextBox25.Text) + (2005 + 12 + 14 + 27.382 + 88.388 + 55 + 25) / rtwo6.Next(10,1500)) / r26.Next(1,100)));
            Random r27 = new Random(); Random rtwo7 = new Random();
            TextBox27.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox19.Text) + float.Parse(TextBox20.Text) + float.Parse(TextBox21.Text) + float.Parse(TextBox28.Text) + float.Parse(TextBox35.Text) + float.Parse(TextBox34.Text) + float.Parse(TextBox33.Text) + float.Parse(TextBox26.Text) + (2006 + 3 + 14 + 27.382 + 88.388 + 55 + 25) / rtwo7.Next(10,1500)) / r27.Next(1,100)));
            Random r28 = new Random(); Random rtwo8 = new Random();
            TextBox28.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox20.Text) + float.Parse(TextBox21.Text) + float.Parse(TextBox22.Text) + float.Parse(TextBox29.Text) + float.Parse(TextBox36.Text) + float.Parse(TextBox35.Text) + float.Parse(TextBox34.Text) + float.Parse(TextBox27.Text) + (1988 + 8 + 6 + 27.382 + 88.388 + 55 + 25) / rtwo8.Next(10,1500)) / r28.Next(1,100)));
            Random r29 = new Random(); Random rtwo9 = new Random();
            TextBox29.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox21.Text) + float.Parse(TextBox22.Text) + float.Parse(TextBox36.Text) + float.Parse(TextBox35.Text) + float.Parse(TextBox28.Text) + (1988 + 2 + 6 + 27.382 + 88.388 + 55 + 25) / rtwo9.Next(10,1500)) / r29.Next(1,100)));
            // 4th row 30.476°N   79.255°E time: 07:09:54  
            Random r30 = new Random(); Random rthreezero = new Random();
            TextBox30.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox23.Text) + float.Parse(TextBox24.Text) + float.Parse(TextBox31.Text) + float.Parse(TextBox38.Text) + float.Parse(TextBox37.Text) + (2007 + 11 + 6 + 30.476 + 79.255 + 07 + 09 + 54) / rthreezero.Next(10,1500)) / r30.Next(1,100)));
            Random r31 = new Random(); Random rthree1 = new Random();
            TextBox31.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox23.Text) + float.Parse(TextBox24.Text) + float.Parse(TextBox25.Text) + float.Parse(TextBox32.Text) + float.Parse(TextBox39.Text) + float.Parse(TextBox38.Text) + float.Parse(TextBox37.Text) + float.Parse(TextBox30.Text) + (2006 + 3 + 7 + 30.476 + 79.255 + 07 + 09 + 54) / rthree1.Next(10,1500)) / r31.Next(1,100)));
            Random r32 = new Random(); Random rthree2 = new Random();
            TextBox32.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox24.Text) + float.Parse(TextBox25.Text) + float.Parse(TextBox26.Text) + float.Parse(TextBox33.Text) + float.Parse(TextBox40.Text) + float.Parse(TextBox39.Text) + float.Parse(TextBox38.Text) + float.Parse(TextBox31.Text) + (2006 + 2 + 14 + 30.476 + 79.255 + 07 + 09 + 54) / rthree2.Next(10,1500)) / r32.Next(1,100)));
            Random r33 = new Random(); Random rthree3 = new Random();
            TextBox33.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox25.Text) + float.Parse(TextBox26.Text) + float.Parse(TextBox27.Text) + float.Parse(TextBox34.Text) + float.Parse(TextBox41.Text) + float.Parse(TextBox40.Text) + float.Parse(TextBox39.Text) + float.Parse(TextBox32.Text) + (2005 + 12 + 14 + 30.476 + 79.255 + 07 + 09 + 54) / rthree3.Next(10,1500)) / r33.Next(1,100)));
            Random r34 = new Random(); Random rthree4 = new Random();
            TextBox34.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox26.Text) + float.Parse(TextBox27.Text) + float.Parse(TextBox28.Text) + float.Parse(TextBox35.Text) + float.Parse(TextBox42.Text) + float.Parse(TextBox41.Text) + float.Parse(TextBox40.Text) + float.Parse(TextBox33.Text) + (2006 + 3 + 14 + 30.476 + 79.255 + 07 + 09 + 54) / rthree4.Next(10,1500)) / r34.Next(1,100)));
            Random r35 = new Random(); Random rthree5 = new Random();
            TextBox35.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox27.Text) + float.Parse(TextBox28.Text) + float.Parse(TextBox29.Text) + float.Parse(TextBox36.Text) + float.Parse(TextBox43.Text) + float.Parse(TextBox42.Text) + float.Parse(TextBox41.Text) + float.Parse(TextBox34.Text) + (1988 + 8 + 6 + 30.476 + 79.255 + 07 + 09 + 54) / rthree5.Next(10,1500)) / r35.Next(1,100)));
            Random r36 = new Random(); Random rthree6 = new Random();
            TextBox36.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox28.Text) + float.Parse(TextBox29.Text) + float.Parse(TextBox43.Text) + float.Parse(TextBox42.Text) + float.Parse(TextBox35.Text) + (1988 + 2 + 6 + 30.476 + 79.255 + 07 + 09 + 54) / rthree6.Next(10,1500)) / r36.Next(1,100)));
            // 5th row 17.145°N   73.730°E  time: 09:43:49
            Random r37 = new Random(); Random rthree7 = new Random();
            TextBox37.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox30.Text) + float.Parse(TextBox31.Text) + float.Parse(TextBox38.Text) + float.Parse(TextBox45.Text) + float.Parse(TextBox44.Text) + (2007 + 11 + 6 + 17.145 + 73.730 + 09 + 43 + 49) / rthree7.Next(10,1500)) / r37.Next(1,100)));
            Random r38 = new Random(); Random rthree8 = new Random();
            TextBox38.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox30.Text) + float.Parse(TextBox31.Text) + float.Parse(TextBox32.Text) + float.Parse(TextBox39.Text) + float.Parse(TextBox46.Text) + float.Parse(TextBox45.Text) + float.Parse(TextBox44.Text) + float.Parse(TextBox37.Text) + (2006 + 3 + 7 + 17.145 + 73.730 + 09 + 43 + 49) / rthree8.Next(10,1500)) / r38.Next(1,100)));
            Random r39 = new Random(); Random rthree9 = new Random();
            TextBox39.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox31.Text) + float.Parse(TextBox32.Text) + float.Parse(TextBox33.Text) + float.Parse(TextBox40.Text) + float.Parse(TextBox47.Text) + float.Parse(TextBox46.Text) + float.Parse(TextBox45.Text) + float.Parse(TextBox38.Text) + (2006 + 2 + 14 + 17.145 + 73.730 + 09 + 43 + 49) / rthree9.Next(10,1500)) / r39.Next(1,100)));
            Random r40 = new Random(); Random rforty = new Random();
            TextBox40.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox32.Text) + float.Parse(TextBox33.Text) + float.Parse(TextBox34.Text) + float.Parse(TextBox41.Text) + float.Parse(TextBox48.Text) + float.Parse(TextBox47.Text) + float.Parse(TextBox46.Text) + float.Parse(TextBox39.Text) + (2005 + 12 + 14 + 17.145 + 73.730 + 09 + 43 + 49) / rforty.Next(10,1500)) / r40.Next(1,100)));
            Random r41 = new Random(); Random rforty1 = new Random();
            TextBox41.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox33.Text) + float.Parse(TextBox34.Text) + float.Parse(TextBox35.Text) + float.Parse(TextBox42.Text) + float.Parse(TextBox49.Text) + float.Parse(TextBox48.Text) + float.Parse(TextBox47.Text) + float.Parse(TextBox40.Text) + (2006 + 3 + 14 + 17.145 + 73.730 + 09 + 43 + 49) / rforty1.Next(10,1500)) / r41.Next(1,100)));
            Random r42 = new Random(); Random rforty2 = new Random();
            TextBox42.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox34.Text) + float.Parse(TextBox35.Text) + float.Parse(TextBox36.Text) + float.Parse(TextBox43.Text) + float.Parse(TextBox50.Text) + float.Parse(TextBox49.Text) + float.Parse(TextBox48.Text) + float.Parse(TextBox41.Text) + (1988 + 8 + 6 + 17.145 + 73.730 + 09 + 43 + 49) / rforty2.Next(10,1500)) / r42.Next(1,100)));
            Random r43 = new Random(); Random rforty3 = new Random();
            TextBox43.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox35.Text) + float.Parse(TextBox36.Text) + float.Parse(TextBox50.Text) + float.Parse(TextBox49.Text) + float.Parse(TextBox42.Text) + (1988 + 2 + 6 + 17.145 + 73.730 + 09 + 43 + 49) / rforty3.Next(10,1500)) / r43.Next(1,100)));
            // 6th row 25.149°N   95.127°E time: 00:36:24 
            Random r44 = new Random(); Random rforty4 = new Random();
            TextBox44.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox37.Text) + float.Parse(TextBox38.Text) + float.Parse(TextBox45.Text) + float.Parse(TextBox52.Text) + float.Parse(TextBox51.Text) + (2007 + 11 + 6 + 25.149 + 95.127 + 36 + 24) / rforty4.Next(10,1500)) / r44.Next(1,100)));
            Random r45 = new Random(); Random rforty5 = new Random();
            TextBox45.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox37.Text) + float.Parse(TextBox38.Text) + float.Parse(TextBox39.Text) + float.Parse(TextBox46.Text) + float.Parse(TextBox53.Text) + float.Parse(TextBox52.Text) + float.Parse(TextBox51.Text) + float.Parse(TextBox44.Text) + (2006 + 3 + 7 + 25.149 + 95.127 + 36 + 24) / rforty5.Next(10,1500)) / r45.Next(1,100)));
            Random r46 = new Random(); Random rforty6 = new Random();
            TextBox46.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox38.Text) + float.Parse(TextBox39.Text) + float.Parse(TextBox40.Text) + float.Parse(TextBox47.Text) + float.Parse(TextBox54.Text) + float.Parse(TextBox53.Text) + float.Parse(TextBox52.Text) + float.Parse(TextBox45.Text) + (2006 + 2 + 14 + 25.149 + 95.127 + 36 + 24) / rforty6.Next(10,1500)) / r46.Next(1,100)));
            Random r47 = new Random(); Random rforty7 = new Random();
            TextBox47.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox39.Text) + float.Parse(TextBox40.Text) + float.Parse(TextBox41.Text) + float.Parse(TextBox48.Text) + float.Parse(TextBox55.Text) + float.Parse(TextBox47.Text) + float.Parse(TextBox46.Text) + float.Parse(TextBox39.Text) + (2005 + 12 + 14 + 25.149 + 95.127 + 36 + 24) / rforty7.Next(10,1500)) / r47.Next(1,100)));
            Random r48 = new Random(); Random rforty8 = new Random();
            TextBox48.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox40.Text) + float.Parse(TextBox41.Text) + float.Parse(TextBox42.Text) + float.Parse(TextBox49.Text) + float.Parse(TextBox56.Text) + float.Parse(TextBox48.Text) + float.Parse(TextBox47.Text) + float.Parse(TextBox40.Text) + (2006 + 3 + 14 + 25.149 + 95.127 + 36 + 24) / rforty8.Next(10,1500)) / r48.Next(1,100)));
            Random r49 = new Random(); Random rforty9 = new Random();
            TextBox49.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox41.Text) + float.Parse(TextBox42.Text) + float.Parse(TextBox43.Text) + float.Parse(TextBox50.Text) + float.Parse(TextBox57.Text) + float.Parse(TextBox49.Text) + float.Parse(TextBox48.Text) + float.Parse(TextBox41.Text) + (1988 + 8 + 6 + 25.149 + 95.127 + 36 + 24) / rforty9.Next(10,1500)) / r49.Next(1,100)));
            Random r50 = new Random(); Random rfifty = new Random();
            TextBox50.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox42.Text) + float.Parse(TextBox43.Text) + float.Parse(TextBox57.Text) + float.Parse(TextBox56.Text) + float.Parse(TextBox49.Text) + (1988 + 2 + 6 + 25.149 + 95.127 + 36 + 24) / rfifty.Next(10,1500)) / r50.Next(1,100)));
            // 7th row 24.688°N   91.570°E time:14:50:45 
            Random r51 = new Random(); Random rfifty1 = new Random();
            TextBox51.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox44.Text) + float.Parse(TextBox45.Text) + float.Parse(TextBox52.Text) + (2007 + 11 + 6 + 24.688 + 91.570 + 14 + 50 + 45) / rfifty1.Next(10,1500)) / r51.Next(1,100)));
            Random r52 = new Random(); Random rfifty2 = new Random();
            TextBox52.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox44.Text) + float.Parse(TextBox45.Text) + float.Parse(TextBox46.Text) + float.Parse(TextBox53.Text) + float.Parse(TextBox51.Text) + (2006 + 3 + 7 + 24.688 + 91.570 + 14 + 50 + 45) / rfifty2.Next(10,1500)) / r52.Next(1,100)));
            Random r53 = new Random(); Random rfifty3 = new Random();
            TextBox53.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox45.Text) + float.Parse(TextBox46.Text) + float.Parse(TextBox47.Text) + float.Parse(TextBox47.Text) + float.Parse(TextBox54.Text) + (2006 + 2 + 14 + 24.688 + 91.570 + 14 + 50 + 45) / rfifty3.Next(10,1500)) / r53.Next(1,100)));
            Random r54 = new Random(); Random rfifty4 = new Random();
            TextBox54.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox46.Text) + float.Parse(TextBox47.Text) + float.Parse(TextBox48.Text) + float.Parse(TextBox48.Text) + float.Parse(TextBox55.Text) + (2005 + 12 + 14 + 24.688 + 91.570 + 14 + 50 + 45) / rfifty4.Next(10,1500)) / r54.Next(1,100)));
            Random r55 = new Random(); Random rfifty5 = new Random();
            TextBox55.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox47.Text) + float.Parse(TextBox48.Text) + float.Parse(TextBox49.Text) + float.Parse(TextBox49.Text) + float.Parse(TextBox56.Text) + (2006 + 3 + 14 + 24.688 + 91.570 + 14 + 50 + 45) / rfifty5.Next(10,1500)) / r55.Next(1,100)));
            Random r56 = new Random(); Random rfifty6 = new Random();
            TextBox56.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox48.Text) + float.Parse(TextBox49.Text) + float.Parse(TextBox50.Text) + float.Parse(TextBox50.Text) + float.Parse(TextBox57.Text) + (1988 + 8 + 6 + 24.688 + 91.570 + 14 + 50 + 45) / rfifty6.Next(10,1500)) / r56.Next(1,100)));
            Random r57 = new Random(); Random rfifty7 = new Random();
            TextBox57.Text = Convert.ToString(Convert.ToInt64((float.Parse(TextBox49.Text) + float.Parse(TextBox50.Text) + float.Parse(TextBox56.Text) + (1988 + 2 + 6 + 25.149 + 95.127 + 36 + 24) / rfifty7.Next(10,1500)) / r57.Next(1,100))); 


        }

        protected void Button5_Click(object sender, EventArgs e){
//        {Just use yourIntVariable.ToString();

//Everything in .NET has a .ToString();

//If you need to convert back then it is int.Parse(yourString) etc.
            //int x = Int32.Parse(TextBoxD1.Text);
            Random r = new Random();
            TextBox58.Text = Convert.ToString(Convert.ToInt64(float.Parse(TextBox9.Text)) * r.Next(1,100));
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            TextBox9.Text = Convert.ToString("9");
            TextBox10.Text = Convert.ToString("10");
            TextBox11.Text = Convert.ToString("11");
            TextBox12.Text = Convert.ToString("12");
            TextBox13.Text = Convert.ToString("13");
            TextBox14.Text = Convert.ToString("14");
            TextBox15.Text = Convert.ToString("15");
            TextBox16.Text = Convert.ToString("16");
            TextBox17.Text = Convert.ToString("17");
            TextBox18.Text = Convert.ToString("18");
            TextBox19.Text = Convert.ToString("19");
            TextBox20.Text = Convert.ToString("20");
            TextBox21.Text = Convert.ToString("21");
            TextBox22.Text = Convert.ToString("22");
            TextBox23.Text = Convert.ToString("23");
            TextBox24.Text = Convert.ToString("24");
            TextBox25.Text = Convert.ToString("25");
            TextBox26.Text = Convert.ToString("26");
            TextBox27.Text = Convert.ToString("27");
            TextBox28.Text = Convert.ToString("28");
            TextBox29.Text = Convert.ToString("29");
            TextBox30.Text = Convert.ToString("30");
            TextBox31.Text = Convert.ToString("31");
            TextBox32.Text = Convert.ToString("32");
            TextBox33.Text = Convert.ToString("33");
            TextBox34.Text = Convert.ToString("34");
            TextBox35.Text = Convert.ToString("35");
            TextBox36.Text = Convert.ToString("36");
            TextBox37.Text = Convert.ToString("37");
            TextBox38.Text = Convert.ToString("38");
            TextBox39.Text = Convert.ToString("39");
            TextBox40.Text = Convert.ToString("40");
            TextBox41.Text = Convert.ToString("41");
            TextBox42.Text = Convert.ToString("42");
            TextBox43.Text = Convert.ToString("43");
            TextBox44.Text = Convert.ToString("44");
            TextBox45.Text = Convert.ToString("45");
            TextBox46.Text = Convert.ToString("46");
            TextBox47.Text = Convert.ToString("47");
            TextBox48.Text = Convert.ToString("48");
            TextBox49.Text = Convert.ToString("49");
            TextBox50.Text = Convert.ToString("50");
            TextBox51.Text = Convert.ToString("51");
            TextBox52.Text = Convert.ToString("52");
            TextBox53.Text = Convert.ToString("53");
            TextBox54.Text = Convert.ToString("54");
            TextBox55.Text = Convert.ToString("55");
            TextBox56.Text = Convert.ToString("56");
            TextBox57.Text = Convert.ToString("57");




        }


        

        

        

        

    }
}
