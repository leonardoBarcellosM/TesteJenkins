using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class AprovacaoIesSteps
    {
        AprovacaoIesActions pageAction = new AprovacaoIesActions();

        [Given(@"Acesso a opcao aprovacao")]
        public void GivenAcessoAprovacao()
        {
            var result = pageAction.AcessarAprovacao();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True, "Erro ao acessar a opção aprovação!");
            });
        }

        [When(@"Pesquiso a solicitacao desejada")]
        public void WhenPesquisoASolicitacaoDesejada()
        {
            var result = pageAction.PesquisarSolicitacao();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True, "Erro ao pesquisar solicitação!");
            });
        }

        [When(@"Clico em prosseguir confirmacao")]
        public void WhenClicoEmProsseguir()
        {
            var result = pageAction.ClicarEmProsseguir();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True, "Erro ao pesquisar solicitação!");
            });
        }

        [Then(@"Valido o acesso a tela aprovar solicitacao")]
        public void ThenValidarAcessoATelaAprovarSolicitacao()
        {
            var result = pageAction.ValidarTelaAprovar();
            //result = false;
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True, "Erro ao acessar o endereço solicitado!");
            });
        }

        [Given(@"Preencho os dados pendentes")]
        public void GivenPreenchoOsDadosPendentes()
        {
            var result = pageAction.InserirDadosPendentes();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True, "Erro ao preencher os dados pendentes");
            });
        }

        [When(@"Preencho as informacoes de valores")]
        public void WhenPreenchoAsInformacoesDeValores()
        {
            var result = pageAction.InserirValores();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True, "Erro ao preencher os valores do contrato!");
            });
        }

        [When(@"Clico em aprovar")]
        public void WhenClicoEmAprovar()
        {
            var result = pageAction.ClicarEmAprovar();
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True, "Erro ao aprovar!");
            });
        }

        [Then(@"Valido solicitacao aprovada com sucesso")]
        public void ThenValidarSolicitacaoAprovada()
        {
            var result = pageAction.ValidarAprovacao();
            //result = false;
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True, "Erro ao acessar o endereço solicitado!");
            });
        }
    }
}
