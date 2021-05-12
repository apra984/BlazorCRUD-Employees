pipeline{

agent any
  parameters{
    choice(name:'VERSION', choices: ['1.1.2', '6.96.2'])
  }
  //environment{
  //credentials
  //}
  //tools{
    //gradle, maven
  //}
  
  stages{
  
    stage("build"){
      steps{
         bat "msbuild.exe ${workspace}\\BlazorCRUD.sln /nologo /nr:false  /p:platform=\"x64\" /p:configuration=\"release\" /t:clean;restore;rebuild"
      }
      
  }
        stage("test"){
          //when{
          
            //expression{
            //specify branch
            
            
        //}
          //}
          
          
          
      steps{
        echo 'test app'
         }
      
  }
        stage("deploy"){
      steps{
        echo 'deploy app'
           }
      
      }
  
    }
}

//post{
//have always and failure blocks
//}


node{
//groovy script
}
