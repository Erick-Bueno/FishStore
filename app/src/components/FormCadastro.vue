<template>
    <section class="container">
        <section>
            <h1 class="tit">Cadastro</h1>
            <p class="erru" v-show="ver">{{backErrors}}</p>
            <form action="">
                
                <div class="inputttt">
                    <b-form-group :invalid-feedback="errosNome">
                        <b-form-input class="a" autocomplete="off" v-model="v$.Nome.$model" required type="text" :state="validar" id="nome" placeholder="" aria-describedby="msgerro"></b-form-input>
                        <label for="nome">Nome</label>
                    </b-form-group>
                   </div>
        
                <div class="inputttt">
                        <b-form-input  class="a" autocomplete="off"  v-model="v$.Email.$model" :state="validar2" required type="text" id="email" placeholder="" aria-describedby="emailmsg">
                    </b-form-input>
                    <b-form-invalid-feedback>Informe um email valido</b-form-invalid-feedback>
                    <label for="email">Email</label>
                </div>
                <div class="inputttt  senha">
                    <b-form-group class="group" :invalid-feedback="errosSenha">
                        <b-form-input class="a" v-model="v$.Senha.$model" :state="validar3" required :type="tipo" id="senha" placeholder=""> </b-form-input>   
                        <img @click="showPass"  v-show="!visivel" class="ocultar" src="/imgs/ocultar.png" alt=""> <img @click="showPass" class="ocultar" v-show="visivel" src="/imgs/olho.png" alt="">
                        <label for="senha">Senha</label>
                    </b-form-group>
                    
                </div>
                
                <button @click="cadastro" class="singup-button">Cadastrar</button>
               
                


             
            </form>
        </section>
        <section class="slogan">
            <p class="fish">Fish Store</p>
            <p class="osme">Os melhores peixes você <br> encontra aqui!</p>
        </section>
    </section>
    
</template>
<script>

    import useVuelidate from '@vuelidate/core'
    import { required, senha, email, minLength, sameAs } from '@vuelidate/validators'


    export default{
        name: 'formCadastro',
        setup () {
        return { v$: useVuelidate() }
        },
       
        data(){
            return{
                Nome:'',
                Email:'',
                Senha:'',
                jwt:null,
                id: null,
                tipo:'password',
                visivel: false,
                backErrors: null,
                ver: false
             

            }
        },
        validations(){
            return{
                Nome:{required, minLength: minLength(4)},
                Email:{required, email},
                Senha:{required}
        }
    },
       
        methods:{
            async cadastro(e){
                this.v$.$touch()
                e.preventDefault()
               
                const dado = await fetch("https://localhost:7179/api/Usuario",{
                    method: "POST",
                    headers:{'Accept': 'application/json',
                            'Content-Type': 'application/json'},
                    body: JSON.stringify({
                        "Nome": this.Nome,
                        "Email": this.Email,
                        "Senha": this.Senha,
                        
                    })
                })
                const resp = await dado.json()
                if(resp.status == 403){
                    this.backErrors = resp.msg
                    this.ver = true
                    
                }
                if(resp.status == 400){
                    for(var c  in resp.errors){
                        this.backErrors = resp.errors[c][0]
                        this.ver = true
                    }
                }
                else{
                    var dados = resp.split(",")
                    var id = dados[0]
                    var jwt = dados[1]
                    this.$store.commit('setid', id)
                    this.$store.commit('setToken', jwt)
                    console.log(this.$store.state.user.id)
                    this.$router.push('/')
                }
                setTimeout(() => {
                    this.ver = false
                }, 4000);
                
                
            },
            showPass(){
                if(this.tipo == 'text'){
                    this.tipo = 'password'
                    this.visivel = false
                    
                   
                }
                else{
                    this.tipo = 'text'
                    this.visivel = true
                    
                }
            }
        },
        computed:{
            errosNome(){
                if(this.Nome.length >0 && this.Nome.length < 4){
                    return "Insira um nome de pelo menos 4 caracteres"
                }
              
            },  
            validar(){
                //se o campo ainda n foi mexido retorne nada, $dirty indica q o campo ainnda n foi mexido
                if(this.v$.Nome.$dirty === false){
                    return null
                }
                return !this.v$.Nome.$error
            },
            validar2(){
                if(this.v$.Email.$dirty === false){
                    return null
                }
                //por padrão se tivesse erro ele retornaria true porem o state recebendo true entenderia como algo valido entt para q n ocorra isso a gente nega ou seja se tiver erro o state recebera false entendenddo como erro
                return !this.v$.Email.$error
            },
            validar3(){
                if(this.v$.Senha.$dirty === false){
                    return null
                }
                return !this.v$.Senha.$error
            }
        } 
    } 
</script>
<style scoped>

.erru{
    background-color: red;
    width: 200px; 
    text-align: center;
    color: white;
    border: 2px solid black;
    margin-left: 120px;
}
.group{
    position: relative;
}

.ocultar{
    position: absolute;
    top:0;
    right: 0;
    cursor: pointer;
}
.msge{
    position: absolute;
    top:35px
}
.fish{
    color: white;
    font-size: 60px;
    font-weight: bolder;

}
.a{
    border-radius: 0;
    padding-left: 5px;
}
.a:focus{
    background-color: transparent;
    
    color: white;
    box-shadow: 0 0 0 0.25rem rgb(221 53 69 / 0%);
    

}
.was-validated .form-control:valid:focus, .form-control.is-valid:focus {
    border-color: #198754;
    box-shadow: 0 0 0 0.25rem rgb(255 255 255 / 0%);
}
.was-validated .form-control:invalid:focus, .form-control.is-invalid:focus {
    border-color: #dc3545;
    box-shadow: 0 0 0 0.25rem rgb(221 53 69 / 0%);
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
       
        color: white;
       
        
    }
    .inputttt{
        position: relative;
        padding: 3px;
        height: 48px;
        margin-top: 20px;
       
    }
    .inputttt label{
        position: absolute;
        font-size: 16px;
        color: rgba(255, 255, 255, 0.459);
        font-family: Verdana, Geneva, Tahoma, sans-serif;
        left: 5px;
        top: 12px;
        transition: 0.2s;
        cursor:auto;
    }
 
    .inputttt input:focus ~ label,
    .inputttt input:valid ~ label{
        transform: translateY(-30px);
        font-size: 12px;
        color:#e9e9e9;
        background-color: transparent;
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
        margin-top: 20px;
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
    @media screen and (max-width: 768px){
       .slogan{
        display: none;
       } 
    }
    @media screen and (max-width: 425px){
        .a{
            width: 100%;
        }
        form{
            margin-left: 50px;
            margin-right: 38px;
        }
        .singup-button{
            margin-left: 60px;
            margin-right: 50px;
        }

    }
    @media screen and (max-width: 375px){
        form{
            margin-left: 0px;
        }
        .tit{
            margin-left: 100px;
        }
        .inputttt{
            margin-top: 40px;
            margin-left: 10px;
        }
    }
</style>