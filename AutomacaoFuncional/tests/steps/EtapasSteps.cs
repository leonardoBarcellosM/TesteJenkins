using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class EtapasSteps
    {
        private EtapasActions pageAction = new EtapasActions();

        [Given(@"Acessar a opcao solicitacao")]
        public void GivenAcessarAOpcaoSolicitacao()
        {
           bool result = pageAction.ClicarSolicitacao();

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True, "Erro ao acessar!");
            });
        }

        [When(@"Clicar em quero solicitar o credito")]
        public void WhenClicarEmQueroSolicitarOCredito()
        {
           bool result = pageAction.ClicarSolicitarCredito();

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True, "Erro ao clicar em solicitar crédito!");
            });
        }

        [Then(@"Validar o direcionamento com sucesso")]
        public void ThenValidarODirecionamentoComSucesso()
        {
            var result = pageAction.ValidarDirecionamentoTermosDeUso();

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True, "Erro no direcionamento solicitado!");
            });
        }
    }
}
