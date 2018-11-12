using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class DadosDoEstudanteMap
    {

        [FindsBy(How = How.XPath, Using = "//div[@class='form-group']//input[@id='integrantes']")]
        [CacheLookup]
        public IWebElement InputIntegrantes { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='form-group']//input[@id='renda']")]
        [CacheLookup]
        public IWebElement InputRenda { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='m-t-30']//button[@class='btn btn-laranja btn-block']")]
        [CacheLookup]
        public IWebElement BtnSubmit { get; set; }

    }
}
