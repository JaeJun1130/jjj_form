using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jjj_form
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

                var n3 = 30;
                var n5 = "하하하";
                //변수의 데이터형을 알아내는 메서드->GetType()
                Console.WriteLine("{0}:{1}", n3, n3.GetType());
                Console.WriteLine("{0}:{1}", n5, n5.GetType());
            }

        }
    }
