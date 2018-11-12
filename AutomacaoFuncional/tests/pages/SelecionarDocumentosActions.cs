using AutomacaoFuncional.tests.utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Windows.Forms;

namespace AutomacaoFuncional.tests.pages
{
    class SelecionarDocumentosActions : SelecionarDocumentosMap
    {
        private ClassUtilities util = new ClassUtilities();

        public SelecionarDocumentosActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public void DocsEstudante()
        {
            IWebElement[] list = new IWebElement[] { BtnId01Frente, BtnId01Verso, BtnCpfFrente, BtnResidencia, BtnRenda, BtnMatricula };
            
            try
            {
                for(int cont = 0; cont < list.Length; cont++) {
                    string path = "";
                    Thread.Sleep(1500);
                    util.WaitForElementVisible(list[cont], 15);
                    if (list[cont].Displayed)
                    {
                        path = @"C:\Users\leonardo.barcellos\Desktop\Imagens\teste.jpg";
                        util.ScrollElementoPage(list[cont]);
                        Thread.Sleep(1500);
                        list[cont].Click();
                        Thread.Sleep(1500);
                        IWebElement enviar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='modal-dialog']//div[1]//div[1]//div[2]//div[1]//div[1]//div[1]//a[1]"));
                        util.ScrollElementoPage(enviar);
                        enviar.Click();
                        Thread.Sleep(1500);
                        SendKeys.SendWait(path);
                        SendKeys.SendWait(@"{Enter}");
                        Thread.Sleep(1300);
                        IWebElement Confirm = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='modal-dialog']//div/./div[3]//button[1]"));
                        Thread.Sleep(1300);
                        Confirm.Click();

                       
                    }
                }
            }
            catch
            {

            }
        }

        public void DosGrupoFamiliar()
        {
            IWebElement[] list = new IWebElement[] { BtnIdGF, BtnIdGF2, BtnCpfGF };
            try
            {
                for (int cont = 0; cont < list.Length; cont++)
                {
                    string path = "";
                    Thread.Sleep(3000);
                    util.WaitForElementVisible(list[cont], 15);
                    if (list[cont].Displayed)
                    {
                        path = @"C:\Users\leonardo.barcellos\Desktop\Imagens\teste.jpg";
                        util.ScrollElementoPage(list[cont]);
                        Thread.Sleep(1500);
                        list[cont].Click();
                        Thread.Sleep(1300);
                        IWebElement enviar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='modal-dialog']//div[1]//div[1]//div[2]//div[1]//div[1]//div[1]//a[1]"));
                        util.ScrollElementoPage(enviar);
                        enviar.Click();
                        Thread.Sleep(1300);
                        SendKeys.SendWait(path);
                        SendKeys.SendWait(@"{Enter}");
                        Thread.Sleep(1300);
                        IWebElement Confirm = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='modal-dialog']//div/./div[3]//button[1]"));
                        Thread.Sleep(1300);
                        Confirm.Click();
                    }
                }
            }
            catch
            {

            }
        }

        public void DocsRendaFamiliar()
        {
            string path = "";
            try
            {
                util.WaitForElementVisible(BtnRendaFamiliar, 15);
                if (BtnRendaFamiliar.Displayed)
                {
                    path = @"C:\Users\leonardo.barcellos\Desktop\Imagens\teste.jpg";
                    util.ScrollElementoPage(BtnRendaFamiliar);
                    Thread.Sleep(1500);
                    BtnRendaFamiliar.Click();
                    Thread.Sleep(1300);
                    IWebElement enviar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='modal-dialog']//div[1]//div[1]//div[2]//div[1]//div[1]//div[1]//a[1]"));
                    util.ScrollElementoPage(enviar);
                    enviar.Click();
                    Thread.Sleep(1300);
                    SendKeys.SendWait(path);
                    SendKeys.SendWait(@"{Enter}");
                    Thread.Sleep(1300);
                    IWebElement Confirm = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='modal-dialog']//div/./div[3]//button[1]"));
                    Thread.Sleep(1300);
                    Confirm.Click();
                }
            }
            catch
            {

            }

        }

        public void DocsFiador()
        {
            IWebElement[] list = new IWebElement[] { BtnIdFiadorFrente, BtnIdFiadorVerso, BtnCpfFiador, BtnFiadorResidencia };
            try
            {
                for (int cont = 0; cont < list.Length; cont++)
                {
                    string path = "";
                    Thread.Sleep(3000);
                    util.WaitForElementVisible(list[cont], 15);
                    if (list[cont].Displayed)
                    {
                        path = @"C:\Users\leonardo.barcellos\Desktop\Imagens\teste.jpg";
                        util.ScrollElementoPage(list[cont]);
                        Thread.Sleep(1500);
                        list[cont].Click();
                        Thread.Sleep(1300);
                        IWebElement enviar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='modal-dialog']//div[1]//div[1]//div[2]//div[1]//div[1]//div[1]//a[1]"));
                        util.ScrollElementoPage(enviar);
                        enviar.Click();
                        Thread.Sleep(1300);
                        SendKeys.SendWait(path);
                        SendKeys.SendWait(@"{Enter}");
                        Thread.Sleep(1300);
                        IWebElement Confirm = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='modal-dialog']//div/./div[3]//button[1]"));
                        Thread.Sleep(1300);
                        Confirm.Click();
                    }
                }
            }
            catch
            {

            }
        }

        public void DocsImpostoRenda()
        {
            string path = "";
            try
            {
                util.WaitForElementVisible(BtnImpostoRenda, 15);
                if (BtnRendimentos.Displayed)
                {
                    BtnRendimentos.Click();
                    Thread.Sleep(2000);
                    util.WaitForElementVisible(BtnExtra, 15);
                    if (BtnExtra.Displayed)
                    {
                        path = @"C:\Users\leonardo.barcellos\Desktop\Imagens\teste.jpg";
                        util.ScrollElementoPage(BtnExtra);
                        Thread.Sleep(1500);
                        BtnExtra.Click();
                        Thread.Sleep(1300);
                        IWebElement enviar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='modal-dialog']//div[1]//div[1]//div[2]//div[1]//div[1]//div[1]//a[1]"));
                        util.ScrollElementoPage(enviar);
                        enviar.Click();
                        Thread.Sleep(1300);
                        SendKeys.SendWait(path);
                        SendKeys.SendWait(@"{Enter}");
                        Thread.Sleep(1300);
                        IWebElement Confirm = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='modal-dialog']//div/./div[3]//button[1]"));
                        Thread.Sleep(1300);
                        Confirm.Click();
                        Thread.Sleep(1000);
                        IWebElement BtnNao = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='modal-dialog']//div[1]//div[3]//button[2]"));
                        Thread.Sleep(1000);
                        BtnNao.Click();

                        Thread.Sleep(1000);
                        util.ScrollElementoPage(BtnImpostoRenda);
                        Thread.Sleep(1500);
                        BtnImpostoRenda.Click();
                        Thread.Sleep(1300);
                        IWebElement enviar2 = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='modal-dialog']//div[1]//div[1]//div[2]//div[1]//div[1]//div[1]//a[1]"));
                        util.ScrollElementoPage(enviar);
                        enviar2.Click();
                        Thread.Sleep(1300);
                        SendKeys.SendWait(path);
                        SendKeys.SendWait(@"{Enter}");
                        Thread.Sleep(1300);
                        IWebElement Confirm2 = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='modal-dialog']//div/./div[3]//button[1]"));
                        Thread.Sleep(1300);
                        Confirm2.Click();
                        Thread.Sleep(1000);
                        IWebElement BtnNao2 = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='modal-dialog']//div[1]//div[3]//button[2]"));
                        Thread.Sleep(1000);
                        BtnNao2.Click();
                        Thread.Sleep(1000);
                    }
                }
            }
            catch
            {

            }
        }

        public void Concluir()
        {
            try
            {
                Thread.Sleep(2000);
                util.WaitForElementVisible(BtnConcluir, 30);
                if (BtnConcluir.Displayed)
                {
                    BtnConcluir.Click();
                }
            }
            catch
            {

            }
        }

        public bool ValidarConclusao()
        {
            bool _result = false;
            try
            {
                Thread.Sleep(2000);
                IWebElement validar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='modal-body text-center']//h1//strong[text()='UHU, cadastro concluído!']"));
                IWebElement Enviar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//form[@name='formPesquisa']//div[@class='modal-footer']//input[1]"));
                WebDriverWait wait = new WebDriverWait(ClassDriver.GetInstance().Driver, TimeSpan.FromSeconds(45));
                IWebElement emoji = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//form[@name='formPesquisa']//div[1]//div[1]//label[3]")));

                if (emoji.Displayed)
                {
                    _result = true;
                    emoji.Click();
                    Thread.Sleep(1000);
                    Enviar.Click();
                }
            }
            catch
            {

            }
            return _result;
        }

    }
}
