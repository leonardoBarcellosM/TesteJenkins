using AutomacaoFuncional.tests.utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class DadosDoEstudanteActions : DadosDoEstudanteMap
    {
        private ClassUtilities util = new ClassUtilities();

        public DadosDoEstudanteActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool InserirIntegrantes(string arg)
        {
            bool _result = false;
            try
            {
                util.WaitForElementVisible(InputIntegrantes, 15);
                if (InputIntegrantes.Displayed)
                {
                    util.ScrollElementoPage(InputIntegrantes);
                    InputIntegrantes.Click();
                    Thread.Sleep(300);
                    InputIntegrantes.SendKeys(arg);
                    _result = true;
                }
                else
                {

                }

            }
            catch
            {

            }
            return _result;
        }

        public bool InserirRenda(string arg)
        {
            bool _result = false;
            try
            {
                util.WaitForElementVisible(InputRenda, 15);
                if (InputRenda.Displayed)
                {
                    InputRenda.Click();
                    Thread.Sleep(300);
                    InputRenda.SendKeys(arg);
                    _result = true;
                }
                else
                {

                }

            }
            catch
            {

            }
            return _result;
        }

        public bool ClicarEnviar()
        {
            bool _result = false;
            try
            {
                util.WaitForElementVisible(BtnSubmit, 10);
                if (BtnSubmit.Displayed && BtnSubmit.Enabled)
                {
                    BtnSubmit.Click();
                    Thread.Sleep(2000);
                    _result = true;
                }
                else
                {

                }

            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarDirecionamentoEtapa3()
        {
            bool _result = false;
            
            try
            {
                IWebElement Validar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//section[@class='ng-scope']//h2[text()='Dados do Fiador']"));
                util.WaitForElementVisible(Validar, 15);
                if (Validar.Displayed)
                {
                    _result = true;
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "else - Erro Validar etapa 3";
                }

            }
            catch
            {
                util.ScreenshotPrepare();
                ClassInfo.GetInstance().LogMessage = "try - Erro Validar etapa 3";
            }

            return _result;
        }


    }
}
