const btnSair = document.querySelector("#btnSair");
  
  btnSair.addEventListener("click", function(){

    const confirmacao = confirm("Tem certeza de que deseja sair?");
  
    if(confirmacao){
        window.location.href = "../index.html";
    }else{
  
    }

  })