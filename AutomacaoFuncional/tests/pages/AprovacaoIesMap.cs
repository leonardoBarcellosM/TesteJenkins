﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class AprovacaoIesMap
    {
        [FindsBy(How = How.XPath, Using = "//ul[@class='items'][1]//li[2]//a[1]")]
        [CacheLookup]
        public IWebElement OptAprovacao { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='panel panel-default ng-scope'][1]//div/./button[1]")]
        [CacheLookup]
        public IWebElement BtnAprovar { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@name='formBusca']//div[1]//div[1]//div[1]//div[1]//div[1]//input")]
        [CacheLookup]
        public IWebElement InputCpf { get; set; }

        [FindsBy(How = How.XPath, Using = ".//form[@name='formCalculo']/./div[2]//div[2]//div[1]//div[1]//input")]
        [CacheLookup]
        public IWebElement InputMatricula { get; set; }

        [FindsBy(How = How.XPath, Using = ".//form[@name='formCalculo']/./div[2]//div[2]//div[1]//div[3]//input")]
        [CacheLookup]
        public IWebElement InputPercentual { get; set; }

        [FindsBy(How = How.XPath, Using = ".//form[@name='formCalculo']/./div[2]//div[2]//div[1]//div[2]//select")]
        [CacheLookup]
        public IWebElement SelectSemestre { get; set; }

        [FindsBy(How = How.XPath, Using = ".//form[@name='formCalculo']/./div[4]//div[@class='list-group'][1]//div[1]//div[1]//div[1]//input[1]")]
        [CacheLookup]
        public IWebElement InputValor_01 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//form[@name='formCalculo']/./div[4]//div[@class='list-group'][1]//div[1]//div[2]//input[1]")]
        [CacheLookup]
        public IWebElement InputValor_02 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//form[@name='formCalculo']/./div[4]//div[@class='col-md-6'][2]//div[@class='list-group-item']//div[1]//div[1]//input")]
        [CacheLookup]
        public IWebElement InicioContrato { get; set; }

        [FindsBy(How = How.XPath, Using = ".//form[@name='formCalculo']/./div[4]//div[@class='col-md-6'][2]//div[@class='list-group-item']//div[2]//input")]
        [CacheLookup]
        public IWebElement FinalContrato { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='modal-footer ng-scope']/./button[1]")]
        [CacheLookup]
        public IWebElement BtnAprovar02 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//form[@name='formCalculo']/./div[3]//div[1]//div[1]//div[2]//select[1]")]
        [CacheLookup]
        public IWebElement SelectTipo { get; set; }

        [FindsBy(How = How.XPath, Using = ".//form[@name='formCalculo']/./div[4]//div[2]//div[2]//div[1]//input[1]")]
        [CacheLookup]
        public IWebElement InputContrato { get; set; }
        
        
        
        
    }
}