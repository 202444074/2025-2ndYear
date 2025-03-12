using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week02Prog01 // 프로젝트 이름과 같음
// 전체 선택하고 ctrl k누르고 f누르면 간편한 줄 맞추기 가능, ctrl l은 바로 줄 자르기
// ctrl + .으로 에러사항 바로 확인 가능
{
    static class Start // 파일 이름과 같음
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain()); /// new 생성자로 form1파일 안 form1 클래스
        }
    }
}
