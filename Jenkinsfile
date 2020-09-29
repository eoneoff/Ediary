pipeline{
    agent any
    stages{
        stage("compile"){
            steps{
                sh 'dotnet build'
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
                sh 'dotnet test Ediary.Tests/Ediary.Tests.csproj'
            }
        }
    }
}