﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Valtech.Samples.BG.AcceptanceTests.Scenarios
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Health Quote")]
    public partial class HealthQuoteFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "HealthQuote.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Health Quote", "\tIn order to avoid silly mistakes\r\n\tAs a Bupa Global user\r\n\tI want to be able to " +
                    "navigate the site", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Step 1 Checks")]
        [NUnit.Framework.CategoryAttribute("SmokeTest")]
        [NUnit.Framework.CategoryAttribute("Nightly")]
        [NUnit.Framework.CategoryAttribute("TFS1234")]
        public virtual void Step1Checks()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Step 1 Checks", new string[] {
                        "SmokeTest",
                        "Nightly",
                        "TFS1234"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I navigated to the Quote page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I choose Global health insurance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table1.AddRow(new string[] {
                        "country",
                        "Contains",
                        ""});
#line 10
 testRunner.Then("I see", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Full Quote")]
        public virtual void FullQuote()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Full Quote", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.Given("I navigated to the Quote page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
 testRunner.When("I choose Global Health Insurance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "country",
                        "United Kingdom"});
#line 17
 testRunner.When("I enter data", ((string)(null)), table2, "When ");
#line 20
 testRunner.When("I choose Continue To Next Step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.And("I wait for the HealthInsuranceQuote page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("I am on the HealthInsuranceQuote page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "Title",
                        "Mr"});
            table3.AddRow(new string[] {
                        "firstname",
                        "Matt"});
            table3.AddRow(new string[] {
                        "secondname",
                        "Davies"});
            table3.AddRow(new string[] {
                        "day",
                        "14"});
            table3.AddRow(new string[] {
                        "month",
                        "12"});
            table3.AddRow(new string[] {
                        "year",
                        "1980"});
            table3.AddRow(new string[] {
                        "email",
                        "1@bupaglobal.com"});
            table3.AddRow(new string[] {
                        "countrycode",
                        "44"});
            table3.AddRow(new string[] {
                        "phonenumber",
                        "712345678"});
#line 23
 testRunner.When("I enter data", ((string)(null)), table3, "When ");
#line 34
 testRunner.When("I choose PrivacyTickbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.When("I choose GetQuoteButton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.Then("I wait to see See This Plan", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
