pipeline{
    agent{
        label "node"
    }
    stages{
        stage("compile"){
            steps{
                dotnet build
            }
            post{
                success{
                    echo "build success"
                }
                failure{
                    echo "build failed"
                }
            }
        }
        stage("test") {
            steps {
                dotnet test Ediary.Tests/Ediary.Tests.csproj
            }
        }
    }
}