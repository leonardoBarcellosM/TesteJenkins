using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class AccessSteps
    {
        private AcessPageActions pageAction = new AcessPageActions();

        [Given(@"Acessar o endereco ""(.*)""")]
        public void GivenAcessarOEndereco(string url)
        {

            var result = pageAction.AccessPage(url);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True, "Erro ao acessar a URL!");
            });

        }
        
        [Then(@"Validar o carregamento")]
        public void ThenValidarOCarregamentoComSucesso()
        {
            var result = pageAction.ValidAccessPage();
            result = false;
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True, "Erro ao acessar o endereço solicitado!");
            });
        }

        [Then(@"Validar Acesso ao portal")]
        public void ThenValidarAcessoAoPortalIes()
        {
            var result = pageAction.ValidarAcessoIes();
            //result = false;
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True, "Erro ao acessar o endereço solicitado!");
            });
        }  
    }
}
