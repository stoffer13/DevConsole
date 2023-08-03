using DevConsole.Infrastructure.Commands;
using System.Net;

namespace DevConsole;

public class DevConsoleConfig
{
    public string AzureDevOpsOrganizationName => WebUtility.HtmlEncode("umbraco");

    public string AzureDevOpsProjectName => WebUtility.HtmlEncode("Cloud Team");

    public string AzureDevOpsOrganizationUri => $"https://dev.azure.com/{AzureDevOpsOrganizationName}";

    public string AzureTenant => throw new UserActionException("Please set AzureTenant in DevConsole/DevConsoleConfig.cs");
    public string AzureSubscription => throw new UserActionException("Please set AzureSubscription in DevConsole/DevConsoleConfig.cs");
}