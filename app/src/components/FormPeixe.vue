<template>
     <div class="container2">
            <mensagem  v-show="mostrar" :mensagem="mens"></mensagem>
        </div>
    <div class="contu">
        <div class="container">
        
            <form @submit="post" >
                <h1 class="tituloo">Crie o Seu Peixe</h1>
                <div class="inputt">
                    <input v-model="nome_peixe"  required type="text" placeholder="" id="nome">
                    <label for="nome">Nome Do Peixe</label>
                </div>
                <div class="inputtt">
                    <textarea v-model="descricao_peixe" required   name="" id="desc" cols="30" rows="10" maxlength="600"></textarea>
                    <label for="desc">Descrição Do Peixe</label>
                </div>
                <div class="img-cont" @change="pegar">
                    <label tabindex="0" class="imagem" for="imgg">
                        <img v-show="ativo" class="pic" :src="url" alt="">
                        {{img}}
                    </label>
                    <input type="file" id="imgg" :value="val">
                </div>
                <div>
                    <button class="enviar">Criar Peixe</button>
                </div>
            </form>
        </div>
        <img class="peixe" src="/imgs/fish-shop.png" alt="">
    </div>
</template>

<script>

import mensagem from '../components/mensagem.vue'


export default{
    name: 'FormPeixes',
    data(){
        return{
            img: "Selecione a imagem do peixe",
            ativo:false,
            url: null,
            nome_peixe: '',
            descricao_peixe: '',
            imagem_peixe:'',
            mens: [],
            mostrar:false,
            val:'',
            dados: null
           
        }
    },
    components:{
        mensagem
    },
    methods:{
        pegar(e){
            const targett = e.target;
            const nome = targett.files[0]
            const reader = new FileReader()
            reader.onload = (e) =>{
                this.url = e.target.result
               
                
            }
            this.url = reader.readAsDataURL(targett.files[0])
            this.ativo = true
            this.img = ""
            this.imagem_peixe = nome
        },
        async post(e){
            e.preventDefault()
            let formdata = new FormData()
            formdata.append('NomePeixe', this.nome_peixe)
            formdata.append('Descricao', this.descricao_peixe)
            formdata.append('imagem', this.imagem_peixe)
            formdata.append('imagem', "{}")
            
            
                const dado = await fetch("https://localhost:7179/api/Peixe",{
                method: 'POST',
                headers:{
                    'Accept': 'application/json'
                    
                },
                body: formdata
            })
            window.scrollTo({
        top: 0,
        left: 0,
        behavior: "smooth"
    })
            const resp = await dado.json()
            
            if(resp.status == 202){
                this.mens = resp.mensagem
                this.nome_peixe = ''
                this.descricao_peixe = ''
                this.imagem_peixe = ''
                this.img = 'Selecione a imagem do peixe'
                this.ativo = false
                this.url=null
            }
            else{
                //console.log(resp.errors.NomePeixe)
                const dados = resp.errors
                

                for(const dado in dados){
                    
                    this.mens = dados[dado][0]
                   
                }
            }
               
              
                this.mostrar = true
                setTimeout(() => {
                this.mostrar = false
                this.mensagem = null
            }, 2000);
            
    
            
          
           
           
         
            
            
          
          
            
            
            
        }
    }
}
</script>
<style scoped>
label{
    font-family: arial;
    
}
.contu{
    display: flex;
    flex-direction: row;
    
    
}

.tituloo{
    color: white;
}
.peixe{
    width: 400px;
    height: 400px;
    margin-right: 150px;
    margin-top: 100px;
   
}
.enviar{
    padding: 10px;
    width: 100%;
    border: 3px solid #777779;
    margin-top: 20px;
    margin-bottom: 20px;
    cursor: pointer;
    background-color: #7453F5;
    font-family: 'Courier New', Courier, monospace;
    color: white;
    transition: 0.5s;
    box-shadow:5px 7px 7px -3px rgba(0,0,0,0.62);
    outline: 0;




;
   
}
.enviar:hover{
    background-color: white;
    color: #7453F5;
    border: 3px solid #777779;
    
}
.pic{
    width: 100%;
    border-radius: 10px;
   
    
}
.img-cont{
    padding-top: 40px;
}
.imagem{
    width: 300px;
    background-color: rgb(196, 188, 188);
    font-family: Verdana, Geneva, Tahoma, sans-serif;
    color: #777779;
    display: flex;
    border: 3px dashed #7453F5;
    justify-content: center;
    align-items: center;
    cursor: pointer;
    transition: 0.5s;
    border-radius: 10px;

    
   
}
.imagem:hover{
    background-color: rgb(122, 118, 118);
    color: white;
    border: 3px dashed #787cb9;
    
}
input[type='file']{
    display: none;
}
.desc{
    font-family: Verdana, Geneva, Tahoma, sans-serif;
    font-size: 16px;
    
}
textarea{
    width: 100%;
    border: 0;
    border: 3px solid #431ae7;;
    background-color: #7353f500;
    outline: 0;
    padding-left: 5px;
    resize: none;
    color: white;
}
textarea:focus{
    border: 3px solid #787cb9;
   
}
.container{
    display: flex;
    justify-content: center;
    padding-top: 50px;
    
    
    
}
.container2{
    display: flex;
    justify-content: center;
}   
.inputt{
    position: relative;
    margin-top: 20px;

}
.inputt label{
    font-size: 16px;
    position: absolute;
    left: 5px;
    bottom: 2px;
    color: rgb(161, 160, 160);
    cursor: text;
    transition: 0.2s;
    font-family: Verdana, Geneva, Tahoma, sans-serif;
}
.inputt input{
    width: 100%;
    padding: 5px;
    border: 0;
    background-color: #7353f500;
    padding-left: 5px;
    border-bottom: 3px solid #431ae7;
    outline: 0;
    font-size: 16px;
    color: white;
}
.inputtt label{
 position: absolute;
 left: 5px;
 color: rgb(161, 160, 160);
 cursor: text;
 transition: 0.2s;
 font-family: Verdana, Geneva, Tahoma, sans-serif;
}
.inputtt{
    position: relative;
    padding-top: 40px;
    
}
.inputtt textarea:focus ~ label,
.inputtt textarea:valid ~ label
{
    color: #dcdcdd;
    transform: translateY(-24px);
    font-size: 12px;
}
.inputt input:focus,
.inputt input:valid{
    border-bottom: 3px solid #787cb9;
}
.inputt input:focus ~ label,
.inputt input:valid ~ label{
    transform: translateY(-30px);
    font-size: 12px;
    color:#e9e9e9
}
</style>