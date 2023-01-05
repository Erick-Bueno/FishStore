<template>
    <h1 class="titulo">Login</h1>
    <p class='erro' v-show="mostrar">{{ msg_erro }}</p>
    <section class="cont">
        <section>
            <div class="inputt">
                <b-form-group>
                    <b-form-input v-model="v$.Email.$model" autocomplete="off" class="b" type="Email" required id="Email" placeholder=" " :state="validar">
                    </b-form-input>
                    <label for="Email">Email</label>
                </b-form-group>
            </div>
            <div class="inputt">
                <b-form-group>
                    <b-form-input class="b" v-model="v$.Senha.$model" :state="validar2"  autocomplete="off" type="password" required id="senha" placeholder=" ">
                    </b-form-input>
                    <label for="senha">Senha</label>
                </b-form-group>
            </div>
            <button class="logar" @click="logar">logar</button>
        </section>
    </section>
</template>
<script>
    import useVuelidate from '@vuelidate/core';
    import { email, required } from '@vuelidate/validators';

    export default{
        name:"formlogin",
        data(){
            return{
                v$: useVuelidate(),
                Email: '',
                Senha: '', 
                msg_erro: '',
                mostrar: false
            }
        },
        validations(){
            return{
                Email:{required, email},
                Senha:{required}
            }
        },
        computed:{
            validar(){
                if(this.v$.Email.$dirty === false){
                    return null
                }
                return !this.v$.Email.$error
            },
            validar2(){
                if(this.v$.Senha.$dirty === false){
                    return null
                }
                return !this.v$.Senha.$error
            }
        },
        methods:{
            async logar(){
                this.v$.$touch()
                const dados = await fetch("https://localhost:7179/api/Usuario/logar",{
                    method: "POST",
                    headers:{'Accept': 'application/json',
                            'Content-Type': 'application/json'},
                    body:JSON.stringify({
                        'email': this.Email,
                        'senha': this.Senha
                    })
                })
                const resp = await dados.json()
                if(resp.status == 400){
                    for(var c in resp.errors){
                    this.msg_erro = resp.errors[c][0]
                    
                    }
                    this.mostrar = true
                setTimeout(() => {
                    this.mostrar = false
                }, 4000);
                }
                if(resp.status == 403){
                    this.msg_erro = resp.msg
                    this.mostrar = true
                    setTimeout(() => {
                        this.mostrar=false
                    }, 4000);
                }
                var dados2 = resp.split(",")
                var id = dados2[1]
                var jwt = dados2[0]
                this.$store.commit('setid', id)
                this.$store.commit('setToken', jwt)
                this.$router.push('/')
                
            }
        }
    }
</script>
<style scoped>
.logar{
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
.erro{
    background-color: red;
    width: 200px; 
    text-align: center;
    color: white;
    border: 2px solid black;
    margin-left: 120px;
    margin: auto;
}

.logar:hover{
    background-color: white;
    color: black;
}
.titulo{
    text-align: center;
    margin-top: 60px;
    color: white;
}
.was-validated .form-control:valid:focus, .form-control.is-valid:focus {
    border-color: #198754;
    box-shadow: 0 0 0 0.25rem rgb(255 255 255 / 0%);
}
.was-validated .form-control:invalid:focus, .form-control.is-invalid:focus {
    border-color: #dc3545;
    box-shadow: 0 0 0 0.25rem rgb(221 53 69 / 0%);
}
.cont{
    display: flex;
    justify-content: center;
    align-items: center;
}
input{
        background-color: transparent;
        border: none;
        border-bottom: 2px solid white;
        width: 400px;
        outline: 0;
        border-radius: 0;
        color: white;
        
       
        
    }
    .inputt{
        position: relative;
        margin-top: 20px;
    }
    label{
        position: absolute;
        font-size: 16px;
        color: rgba(255, 255, 255, 0.459);
        font-family: Verdana, Geneva, Tahoma, sans-serif;
        left: 5px;
        top: 12px;
        transition: 0.2s;
        cursor:auto;
    }
    .inputt input:focus ~ label,
    .inputt input:valid ~ label{
        transform: translateY(-30px);
        font-size: 12px;
        color:#e9e9e9;
        background-color: transparent;
    }
    .b:focus{
        background-color: transparent;
        color: white;
        box-shadow: 0 0 0 0.25rem rgb(221 53 69 / 0%);
    }
    @media screen and (max-width: 375px){
        .b{
            width: 100%;
        }
        .logar{
            margin-left: 20px;
        }
    }
  
</style>