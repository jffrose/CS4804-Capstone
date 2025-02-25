﻿<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="AzureAEDFinder" generation="1" functional="0" release="0" Id="4e8bea2d-2fa8-410b-9d33-563ad415798e" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="AzureAEDFinderGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="AzureAEDFinderWCFServiceWebRole:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/AzureAEDFinder/AzureAEDFinderGroup/LB:AzureAEDFinderWCFServiceWebRole:Endpoint1" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="AzureAEDFinderWCFServiceWebRole:?IsSimulationEnvironment?" defaultValue="">
          <maps>
            <mapMoniker name="/AzureAEDFinder/AzureAEDFinderGroup/MapAzureAEDFinderWCFServiceWebRole:?IsSimulationEnvironment?" />
          </maps>
        </aCS>
        <aCS name="AzureAEDFinderWCFServiceWebRole:?RoleHostDebugger?" defaultValue="">
          <maps>
            <mapMoniker name="/AzureAEDFinder/AzureAEDFinderGroup/MapAzureAEDFinderWCFServiceWebRole:?RoleHostDebugger?" />
          </maps>
        </aCS>
        <aCS name="AzureAEDFinderWCFServiceWebRole:?StartupTaskDebugger?" defaultValue="">
          <maps>
            <mapMoniker name="/AzureAEDFinder/AzureAEDFinderGroup/MapAzureAEDFinderWCFServiceWebRole:?StartupTaskDebugger?" />
          </maps>
        </aCS>
        <aCS name="AzureAEDFinderWCFServiceWebRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/AzureAEDFinder/AzureAEDFinderGroup/MapAzureAEDFinderWCFServiceWebRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="AzureAEDFinderWCFServiceWebRoleInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/AzureAEDFinder/AzureAEDFinderGroup/MapAzureAEDFinderWCFServiceWebRoleInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:AzureAEDFinderWCFServiceWebRole:Endpoint1">
          <toPorts>
            <inPortMoniker name="/AzureAEDFinder/AzureAEDFinderGroup/AzureAEDFinderWCFServiceWebRole/Endpoint1" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="MapAzureAEDFinderWCFServiceWebRole:?IsSimulationEnvironment?" kind="Identity">
          <setting>
            <aCSMoniker name="/AzureAEDFinder/AzureAEDFinderGroup/AzureAEDFinderWCFServiceWebRole/?IsSimulationEnvironment?" />
          </setting>
        </map>
        <map name="MapAzureAEDFinderWCFServiceWebRole:?RoleHostDebugger?" kind="Identity">
          <setting>
            <aCSMoniker name="/AzureAEDFinder/AzureAEDFinderGroup/AzureAEDFinderWCFServiceWebRole/?RoleHostDebugger?" />
          </setting>
        </map>
        <map name="MapAzureAEDFinderWCFServiceWebRole:?StartupTaskDebugger?" kind="Identity">
          <setting>
            <aCSMoniker name="/AzureAEDFinder/AzureAEDFinderGroup/AzureAEDFinderWCFServiceWebRole/?StartupTaskDebugger?" />
          </setting>
        </map>
        <map name="MapAzureAEDFinderWCFServiceWebRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/AzureAEDFinder/AzureAEDFinderGroup/AzureAEDFinderWCFServiceWebRole/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapAzureAEDFinderWCFServiceWebRoleInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/AzureAEDFinder/AzureAEDFinderGroup/AzureAEDFinderWCFServiceWebRoleInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="AzureAEDFinderWCFServiceWebRole" generation="1" functional="0" release="0" software="C:\Users\Jeff\Documents\Visual Studio 2010\Projects\CS4804-Capstone\AzureAEDFinder\AzureAEDFinder\bin\Debug\AzureAEDFinder.csx\roles\AzureAEDFinderWCFServiceWebRole" entryPoint="base\x86\WaHostBootstrapper.exe" parameters="base\x86\WaIISHost.exe " memIndex="1792" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
            </componentports>
            <settings>
              <aCS name="?IsSimulationEnvironment?" defaultValue="" />
              <aCS name="?RoleHostDebugger?" defaultValue="" />
              <aCS name="?StartupTaskDebugger?" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;AzureAEDFinderWCFServiceWebRole&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;AzureAEDFinderWCFServiceWebRole&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="WCFServiceWebRole1.svclog" defaultAmount="[1000,1000,1000]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/AzureAEDFinder/AzureAEDFinderGroup/AzureAEDFinderWCFServiceWebRoleInstances" />
            <sCSPolicyFaultDomainMoniker name="/AzureAEDFinder/AzureAEDFinderGroup/AzureAEDFinderWCFServiceWebRoleFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyFaultDomain name="AzureAEDFinderWCFServiceWebRoleFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="AzureAEDFinderWCFServiceWebRoleInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="b4884add-af08-4457-89b7-e3822ba1fc13" ref="Microsoft.RedDog.Contract\ServiceContract\AzureAEDFinderContract@ServiceDefinition.build">
      <interfacereferences>
        <interfaceReference Id="c0d480b9-d557-43b7-a312-1cb111777a73" ref="Microsoft.RedDog.Contract\Interface\AzureAEDFinderWCFServiceWebRole:Endpoint1@ServiceDefinition.build">
          <inPort>
            <inPortMoniker name="/AzureAEDFinder/AzureAEDFinderGroup/AzureAEDFinderWCFServiceWebRole:Endpoint1" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>