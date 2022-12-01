<template>
    <section class="container">
        <section>
            <h1 class="tit">Cadastro</h1>
            <form action="">
                <div class="inputttt">
                    <input required type="text" id="nome" placeholder="">
                    <label for="nome">Nome</label>
                </div>
                <div class="inputttt">
                    <input required type="email" id="email" placeholder="">
                    <label for="email">Email</label>
                </div>
                <div class="inputttt">
                    <input required type="password" id="senha" placeholder="">
                    <label for="senha">Senha</label>
                </div>
                <div class="inputttt">
        
                    <input required type="password" id="confirmarsenha" placeholder="">
                    <label for="confirmarsenha">Confirmar Senha</label>
                </div>
                <button class="singup-button">Cadastrar</button>
            </form>
        </section>
        <section class="slogan">
            <p class="fish">Fish Store</p>
            <p class="osme">Os melhores peixes você <br> encontra aqui!</p>
        </section>
    </section>
    
</template>
<script>
    export default{
        name: 'formCadastro'
    }
</script>
<style scoped>
.fish{
    color: white;
    font-size: 60px;
    font-weight: bolder;

}
.container{
    display: flex;
    flex-direction: row;
}
    .slogan{
        margin-top: 50px;
        
    }
    .tit{
        color: white;
        margin-top: 50px;
        margin-left: 120px;
        font-size: 35px;
        font-family: Arial, Helvetica, sans-serif;
        font-weight: bolder;
    }
    input{
        background-color: transparent;
        border: none;
        border-bottom: 2px solid white;
        width: 400px;
        outline: 0;
        margin-bottom: 40px;
        color: white;
        
    }
    .inputttt{
        position: relative;
        padding: 3px;
    }
    .inputttt label{
        position: absolute;
        font-size: 16px;
        color: rgba(255, 255, 255, 0.459);
        font-family: Verdana, Geneva, Tahoma, sans-serif;
        left: 2px;
        transition: 0.2s;
        cursor:auto;
    }
    .inputttt input:focus,
    .inputttt input:valid{
        border-bottom: 2px solid rgb(145, 141, 141);
    }
    .inputttt input:focus ~ label,
    .inputttt input:valid ~ label{
        transform: translateY(-30px);
        font-size: 12px;
        color:#e9e9e9
    }
    .singup-button{
        background-color: transparent;
        color: white;
        width: 200px;
        border-radius: 10px;
        padding: 5px;
        border: 2px solid white;
        font-family: Verdana, Geneva, Tahoma, sans-serif;
        transition: 0.5s;
        cursor: pointer;
        margin-left: 100px;
    }
    .singup-button:hover{
        background-color: white;
        color: black;
    }
    form{
        margin-left: 120px;
        margin-right: 150px;
        margin-top: 40px;
       
    }
    .osme{
        color: white;
        font-size: 25px;
    }
</style>