# Testing Github Workflows
Simple Demo CRUD .NET 6 - Unit Testing Web Api.  
Setting up a simple Github Workflows for Unit Testing following the [Github Guide](https://docs.github.com/en/actions/automating-builds-and-tests/building-and-testing-net).  
Just create a [Workflow file](https://github.com/federicodiluca/NetCore-GithubWorkflows-Demo/blob/master/.github/workflows/test.yml)

## Testing Badge 
You may want to create a simple *workflow badge* to check the testing result after every commit.  

[![Test](https://github.com/federicodiluca/NetCore-GithubWorkflows-Demo/actions/workflows/test.yml/badge.svg)](https://github.com/federicodiluca/NetCore-GithubWorkflows-Demo/actions/workflows/test.yml)


Once you created the *.yml* file you just need to go to the Actions tab, select your action and click on "Create status badge".
![image](https://user-images.githubusercontent.com/68862675/167248234-282f11e5-458e-441a-ae48-4240090343d4.png)

Here it is the [Microsoft reference](https://docs.microsoft.com/en-us/dotnet/devops/dotnet-test-github-action) to create the result badge.
