# ApplicationInsights.StatusCodeFilter

Status code filter for Application Insights to record as success instead of failure for Umbraco 8

## Getting started

### Installation

ApplicationInsights.StatusCodeFilter is available from [Our Umbraco](https://our.umbraco.com/packages/website-utilities/applicationinsights-statuscodefilter/), [NuGet](https://www.nuget.org/packages/AaronSadler.ApplicationInsights.StatusCodeFilter/) or as a manual download directly from GitHub.

## Usage

This package adds a status code filter for Application Insights, this will allow you to mark status codes as success, or exclude them completely from the logs.

## Configurations


By default this will log 404 errors as a success state, and not a fail state.

You can enable or disable it with the below app setting, it is disabled by default

    <add key="ApplicationInsights.StatusCodeFilter.Enabled" value="TRUE OR FALSE" />  

The app setting below will allow this to be overriden with a comma separated list of status codes:

    <add key="ApplicationInsights.StatusCodeFilter.StatusCodes" value="STATUS CODES HERE E.G. 404,401" />


The app setting below will exclude the status codes completely from the log:

    <add key="ApplicationInsights.StatusCodeFilter.Exclude" value="TRUE OR FALSE" />
    
### Contribution guidelines

To raise a new bug, create an issue on the GitHub repository. To fix a bug or add new features, fork the repository and send a pull request with your changes. Feel free to add ideas to the repository's issues list if you would to discuss anything related to the package.

## License

Copyright &copy; 2021 [Aaron Sadler](https://aaronsadler.uk/).

Licensed under the MIT License.