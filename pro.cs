﻿<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="12.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{493E53FF-502A-4BF7-8B25-06C5601A3F52}</ProjectGuid>
    <ProjectTypeGuids>{349c5851-65df-11da-9384-00065b846f21};{fae04ec0-301f-11d3-bf4b-00c04f79efbc}</ProjectTypeGuids>
    <OutputType>Library</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>Online_Survey_System</RootNamespace>
    <AssemblyName>Online-Survey-System</AssemblyName>
    <TargetFrameworkVersion>v4.5</TargetFrameworkVersion>
    <MvcBuildViews>false</MvcBuildViews>
    <UseIISExpress>true</UseIISExpress>
    <IISExpressSSLPort />
    <IISExpressAnonymousAuthentication />
    <IISExpressWindowsAuthentication />
    <IISExpressUseClassicPipelineMode />
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Microsoft.CSharp" />
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Web.DynamicData" />
    <Reference Include="System.Web.Entity" />
    <Reference Include="System.Web.ApplicationServices" />
    <Reference Include="System.ComponentModel.DataAnnotations" />
    <Reference Include="System.Core" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Web" />
    <Reference Include="System.Web.Extensions" />
    <Reference Include="System.Web.Abstractions" />
    <Reference Include="System.Web.Routing" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Configuration" />
    <Reference Include="System.Web.Services" />
    <Reference Include="System.EnterpriseServices" />
    <Reference Include="Microsoft.Web.Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.Web.Infrastructure.1.0.0.0\lib\net40\Microsoft.Web.Infrastructure.dll</HintPath>
    </Reference>
    <Reference Include="System.Net.Http">
    </Reference>
    <Reference Include="System.Net.Http.WebRequest">
    </Reference>
    <Reference Include="System.Web.Helpers, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.AspNet.WebPages.3.0.0\lib\net45\System.Web.Helpers.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.Mvc, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.AspNet.Mvc.5.0.0\lib\net45\System.Web.Mvc.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.Optimization">
      <HintPath>..\packages\Microsoft.AspNet.Web.Optimization.1.1.1\lib\net40\System.Web.Optimization.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.Razor, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.AspNet.Razor.3.0.0\lib\net45\System.Web.Razor.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.WebPages, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.AspNet.WebPages.3.0.0\lib\net45\System.Web.WebPages.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.WebPages.Deployment, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.AspNet.WebPages.3.0.0\lib\net45\System.Web.WebPages.Deployment.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.WebPages.Razor, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.AspNet.WebPages.3.0.0\lib\net45\System.Web.WebPages.Razor.dll</HintPath>
    </Reference>
    <Reference Include="Newtonsoft.Json">
      <Private>True</Private>
      <HintPath>..\packages\Newtonsoft.Json.5.0.6\lib\net45\Newtonsoft.Json.dll</HintPath>
    </Reference>
    <Reference Include="WebGrease">
      <Private>True</Private>
      <HintPath>..\packages\WebGrease.1.5.2\lib\WebGrease.dll</HintPath>
    </Reference>
    <Reference Include="Antlr3.Runtime">
      <Private>True</Private>
      <HintPath>..\packages\Antlr.3.4.1.9004\lib\Antlr3.Runtime.dll</HintPath>
    </Reference>
  </ItemGroup>
  <ItemGroup>
    <Reference Include="EntityFramework">
      <HintPath>..\packages\EntityFramework.6.0.0\lib\net45\EntityFramework.dll</HintPath>
    </Reference>
    <Reference Include="EntityFramework.SqlServer">
      <HintPath>..\packages\EntityFramework.6.0.0\lib\net45\EntityFramework.SqlServer.dll</HintPath>
    </Reference>
    <Reference Include="Microsoft.AspNet.Identity.Core">
      <HintPath>..\packages\Microsoft.AspNet.Identity.Core.1.0.0\lib\net45\Microsoft.AspNet.Identity.Core.dll</HintPath>
    </Reference>
    <Reference Include="Microsoft.AspNet.Identity.Owin">
      <HintPath>..\packages\Microsoft.AspNet.Identity.Owin.1.0.0\lib\net45\Microsoft.AspNet.Identity.Owin.dll</HintPath>
    </Reference>
    <Reference Include="Microsoft.AspNet.Identity.EntityFramework">
      <HintPath>..\packages\Microsoft.AspNet.Identity.EntityFramework.1.0.0\lib\net45\Microsoft.AspNet.Identity.EntityFramework.dll</HintPath>
    </Reference>
    <Reference Include="Owin">
      <HintPath>..\packages\Owin.1.0\lib\net40\Owin.dll</HintPath>
    </Reference>
    <Reference Include="Microsoft.Owin">
      <HintPath>..\packages\Microsoft.Owin.2.0.0\lib\net45\Microsoft.Owin.dll</HintPath>
    </Reference>
    <Reference Include="Microsoft.Owin.Host.SystemWeb">
      <HintPath>..\packages\Microsoft.Owin.Host.SystemWeb.2.0.0\lib\net45\Microsoft.Owin.Host.SystemWeb.dll</HintPath>
    </Reference>
    <Reference Include="Microsoft.Owin.Security">
      <HintPath>..\packages\Microsoft.Owin.Security.2.0.0\lib\net45\Microsoft.Owin.Security.dll</HintPath>
    </Reference>
    <Reference Include="Microsoft.Owin.Security.Facebook">
      <HintPath>..\packages\Microsoft.Owin.Security.Facebook.2.0.0\lib\net45\Microsoft.Owin.Security.Facebook.dll</HintPath>
    </Reference>
    <Reference Include="Microsoft.Owin.Security.Cookies">
      <HintPath>..\packages\Microsoft.Owin.Security.Cookies.2.0.0\lib\net45\Microsoft.Owin.Security.Cookies.dll</HintPath>
    </Reference>
    <Reference Include="Microsoft.Owin.Security.OAuth">
      <HintPath>..\packages\Microsoft.Owin.Security.OAuth.2.0.0\lib\net45\Microsoft.Owin.Security.OAuth.dll</HintPath>
    </Reference>
    <Reference Include="Microsoft.Owin.Security.Google">
      <HintPath>..\packages\Microsoft.Owin.Security.Google.2.0.0\lib\net45\Microsoft.Owin.Security.Google.dll</HintPath>
    </Reference>
    <Reference Include="Microsoft.Owin.Security.Twitter">
      <HintPath>..\packages\Microsoft.Owin.Security.Twitter.2.0.0\lib\net45\Microsoft.Owin.Security.Twitter.dll</HintPath>
    </Reference>
    <Reference Include="Microsoft.Owin.Security.MicrosoftAccount">
      <HintPath>..\packages\Microsoft.Owin.Security.MicrosoftAccount.2.0.0\lib\net45\Microsoft.Owin.Security.MicrosoftAccount.dll</HintPath>
    </Reference>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="App_Start\BundleConfig.cs" />
    <Compile Include="App_Start\FilterConfig.cs" />
    <Compile Include="App_Start\RouteConfig.cs" />
    <Compile Include="App_Start\Startup.Auth.cs" />
    <Compile Include="Controllers\AccountController.cs" />
    <Compile Include="Controllers\HomeController.cs" />
    <Compile Include="Global.asax.cs">
      <DependentUpon>Global.asax</DependentUpon>
    </Compile>
    <Compile Include="Models\AccountViewModels.cs" />
    <Compile Include="Models\IdentityModels.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
    <Compile Include="Startup.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="Content\bootstrap.css" />
    <Content Include="Content\bootstrap.min.css" />
    <Content Include="favicon.ico" />
    <Content Include="fonts\glyphicons-halflings-regular.svg" />
    <Content Include="Global.asax" />
    <Content Include="Content\Site.css" />
    <Content Include="Scripts\bootstrap.js" />
    <Content Include="Scripts\bootstrap.min.js" />
    <None Include="Scripts\jquery-1.10.2.intellisense.js" />
    <Content Include="Scripts\jquery-1.10.2.js" />
    <Content Include="Scripts\jquery-1.10.2.min.js" />
    <None Include="Scripts\jquery.validate-vsdoc.js" />
    <Content Include="Scripts\jquery.validate.js" />
    <Content Include="Scripts\jquery.validate.min.js" />
    <Content Include="Scripts\jquery.validate.unobtrusive.js" />
    <Content Include="Scripts\jquery.validate.unobtrusive.min.js" />
    <Content Include="Scripts\modernizr-2.6.2.js" />
    <Content Include="Scripts\respond.js" />
    <Content Include="Scripts\respond.min.js" />
    <Content Include="Scripts\_references.js" />
    <Content Include="Web.config" />
    <Content Include="Web.Debug.config">
      <DependentUpon>Web.config</DependentUpon>
    </Content>
    <Content Include="Web.Release.config">
      <DependentUpon>Web.config</DependentUpon>
    </Content>
    <Content Include="Views\Web.config" />
    <Content Include="Views\_ViewStart.cshtml" />
    <Content Include="Views\Shared\Error.cshtml" />
    <Content Include="Views\Shared\_Layout.cshtml" />
    <Content Include="Views\Home\About.cshtml" />
    <Content Include="Views\Home\Contact.cshtml" />
    <Content Include="Views\Home\Index.cshtml" />
    <Content Include="Scripts\jquery-1.10.2.min.map" />
    <Content Include="Views\Account\_ChangePasswordPartial.cshtml" />
    <Content Include="Views\Account\_ExternalLoginsListPartial.cshtml" />
    <Content Include="Views\Account\_RemoveAccountPartial.cshtml" />
    <Content Include="Views\Account\_SetPasswordPartial.cshtml" />
    <Content Include="Views\Account\ExternalLoginConfirmation.cshtml" />
    <Content Include="Views\Account\ExternalLoginFailure.cshtml" />
    <Content Include="Views\Account\Login.cshtml" />
    <Content Include="Views\Account\Manage.cshtml" />
    <Content Include="Views\Account\Register.cshtml" />
    <Content Include="Views\Shared\_LoginPartial.cshtml" />
  </ItemGroup>
  <ItemGroup>
    <Folder Include="App_Data\" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="fonts\glyphicons-halflings-regular.woff" />
    <Content Include="fonts\glyphicons-halflings-regular.ttf" />
    <Content Include="fonts\glyphicons-halflings-regular.eot" />
    <Content Include="packages.config" />
    <None Include="Project_Readme.html" />
  </ItemGroup>
  <PropertyGroup>
    <VisualStudioVersion Condition="'$(VisualStudioVersion)' == ''">10.0</VisualStudioVersion>
    <VSToolsPath Condition="'$(VSToolsPath)' == ''">$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v$(VisualStudioVersion)</VSToolsPath>
  </PropertyGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.CSharp.targets" />
  <Import Project="$(VSToolsPath)\WebApplications\Microsoft.WebApplication.targets" Condition="'$(VSToolsPath)' != ''" />
  <Import Project="$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v10.0\WebApplications\Microsoft.WebApplication.targets" Condition="false" />
  <Target Name="MvcBuildViews" AfterTargets="AfterBuild" Condition="'$(MvcBuildViews)'=='true'">
    <AspNetCompiler VirtualPath="temp" PhysicalPath="$(WebProjectOutputDir)" />
  </Target>
  <ProjectExtensions>
    <VisualStudio>
      <FlavorProperties GUID="{349c5851-65df-11da-9384-00065b846f21}">
        <WebProjectProperties>
          <UseIIS>True</UseIIS>
          <AutoAssignPort>True</AutoAssignPort>
          <DevelopmentServerPort>51322</DevelopmentServerPort>
          <DevelopmentServerVPath>/</DevelopmentServerVPath>
          <IISUrl>http://localhost:63742/</IISUrl>
          <NTLMAuthentication>False</NTLMAuthentication>
          <UseCustomServer>False</UseCustomServer>
          <CustomServerUrl>
          </CustomServerUrl>
          <SaveServerSettingsInUserFile>False</SaveServerSettingsInUserFile>
        </WebProjectProperties>
      </FlavorProperties>
    </VisualStudio>
  </ProjectExtensions>
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it.
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name="BeforeBuild">
  </Target>
  <Target Name="AfterBuild">
  </Target> -->
</Project>