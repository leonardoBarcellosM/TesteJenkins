using AutomacaoFuncional.tests.utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class IniciarFluxoComeceAgoraActions : IniciarFluxoComeceAgoraMap
    {
        private MassaDeDados massa = new MassaDeDados();
        private ClassUtilities util = new ClassUtilities();
        private AprovacaoIesActions cpf = new AprovacaoIesActions();

        public IniciarFluxoComeceAgoraActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool PreencherOsDados()
        {
            bool _result = false;
            string mail = util.GerarNumRandom();
            mail = "teste_" + mail + massa.email;

            try
            {
                string cpf = util.GerarCpf();
                UpdateStatusDB.Cpf(cpf);
                

                util.WaitForElementVisible(campoNome, 3);

                if (campoNome.Displayed) {

                    campoNome.Click();
                    campoNome.SendKeys(massa.nome + " " + massa.sobrenome);
                    Thread.Sleep(500);
                    campoCpf.Click();
                    campoCpf.SendKeys(cpf);
                    Thread.Sleep(500);
                    campoTelefone.Click();
                    campoTelefone.SendKeys(massa.telefone);
                    Thread.Sleep(500);
                    campoEmail.Click();
                    campoEmail.SendKeys(mail);
                    Thread.Sleep(500);
                    campoEmailConf.Click();
                    campoEmailConf.SendKeys(mail);
                    Thread.Sleep(500);
                    campoSenha.Click();
                    campoSenha.SendKeys(massa.senha);
                    Thread.Sleep(500);
                    senhaConf.Click();
                    senhaConf.SendKeys(massa.senha);
                    Thread.Sleep(500);

                    _result = true;
                }
                else
                {
                    //Error
                }
            }
            catch
            {
                //Error
            }

            return _result;
        }

        public bool ClicarComeceAgora()
        {
            bool _result = false;

            try
            {
                Thread.Sleep(1000);
                if (btnCadastro.Displayed)
                {
                    btnCadastro.Click();
                    _result = true;
                }
                else
                {
                    util.ScreenshotPrepare();
                }
            }
            catch
            {
                util.ScreenshotPrepare();
            }

            return _result;
        }


        public bool FluxoIniciadoComSucesso()
        {
            bool _result = false;
          
            try
            {
                Thread.Sleep(3000);
                IWebElement BemVindo = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='panel main-panel']"));

                util.WaitForElementVisible(BemVindo, 60);
                if (BemVindo.Displayed)
                {
                    _result = true;
                    Thread.Sleep(1500);
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
    }
}
