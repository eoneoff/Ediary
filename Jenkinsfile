pipeline{
    agent any
    stages{
        stage("compile"){
            steps{
                echo "Compiling"
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
                echo "testing"
            }
        }
    }
}