using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_LoopWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            // 1 ~ 45 6개의 번호 뽑기

            int[] iArray = new int[6];
            int iCount = 0;

            StringBuilder sb = new StringBuilder();
            Random rd = new Random();

            // iArray 가 아직 다 안 찼을 때 계속 진행
            while (Array.IndexOf(iArray, 0) != -1)
            {
                int iNumber = rd.Next(1, 46);


                if( Array.IndexOf(iArray, iNumber) == -1 )
                {
                    iArray[iCount] = iNumber;
                    //sb.Append(string.Format("{0}. ", iNumber));

                    iCount++;
                }
            }

            // 배열 sorting
            Array.Sort(iArray);

            // 배열에 있는 값을 문자로 
            foreach (var item in iArray)
            {
                sb.Append(string.Format("{0}. ", item));
            }


            lblWhileResult.Text = sb.ToString();

            lboxWhileResult.Items.Add(sb.ToString());
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            // 1~100 
            Random rd = new Random();
            
            int iNumber = int.Parse(tboxNumber.Text);

            if (iNumber < 1 || iNumber > 100)
            {
                MessageBox.Show("1~100 사이의 숫자를 지정해 주세요","Category Error");
                return;
            }

            int iCheckNumber = 0;
            int iCount = 0;
            do
            {
                iCheckNumber = rd.Next(1, 101);
                iCount++;

            } while (iNumber != iCheckNumber);

            lblDoWhile.Text = string.Format("- 뽑은 숫자 {0}을 {1}회만에 찾았습니다.", iNumber, iCount);
        }
    }
}