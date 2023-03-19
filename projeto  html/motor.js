function limpa_formulário_cep() {
    //Limpa valores do formulário de cep.
    document.getElementById('rua').value = ("");
    document.getElementById('bairro').value = ("");
    document.getElementById('cidade').value = ("");
    document.getElementById('uf').value = ("");
}

function meu_callback(conteudo) {
    if (!("erro" in conteudo)) {
        //Atualiza os campos com os valores.
        document.getElementById('rua').value = (conteudo.logradouro);
        document.getElementById('bairro').value = (conteudo.bairro);
        document.getElementById('cidade').value = (conteudo.localidade);
        document.getElementById('uf').value = (conteudo.uf);

    } //end if.
    else {
        //CEP não Encontrado.
        limpa_formulário_cep();
        alert("CEP não encontrado.");
    }
}

function pesquisacep(valor) {

    //Nova variável "cep" somente com dígitos.
    var cep = valor.replace(/\D/g, '');

    //Verifica se campo cep possui valor informado.
    if (cep != "") {

        //Expressão regular para validar o CEP.
        var validacep = /^[0-9]{8}$/;

        //Valida o formato do CEP.
        if (validacep.test(cep)) {

            //Preenche os campos com "..." enquanto consulta webservice.
            document.getElementById('rua').value = "...";
            document.getElementById('bairro').value = "...";
            document.getElementById('cidade').value = "...";
            document.getElementById('uf').value = "...";


            //Cria um elemento javascript.
            var script = document.createElement('script');

            //Sincroniza com o callback.
            script.src = 'https://viacep.com.br/ws/' + cep + '/json/?callback=meu_callback';

            //Insere script no documento e carrega o conteúdo.
            document.body.appendChild(script);

        } //end if.
        else {
            //cep é inválido.
            limpa_formulário_cep();
            alert("Formato de CEP inválido.");
        }
    } //end if.
    else {
        //cep sem valor, limpa formulário.
        limpa_formulário_cep();
    }
}




const cpf = document.getElementById('cpf') // Seletor do campo de cpf

cpf.addEventListener('keypress', (e) => mascaraTelefone(e.target.value)) // Dispara quando digitado no campo
cpf.addEventListener('change', (e) => mascaraTelefone(e.target.value)) // Dispara quando autocompletado o campo

const mascaraTelefone = (valor) => {
    valor = valor.replace(/\D/g, "")
    valor = valor.replace(/^(\d{3})(\d)/g, "$1.$2")
    valor = valor.replace(/(\d)(\d{5})$/, "$1.$2")
    valor = valor.replace(/(\d)(\d{2})$/, "$1-$2")
    cpf.value = valor // Insere o(s) valor(es) no campo
}


var alerta = document.getElementById("alerta")
var conteiner = document.getElementById("modalcontainer");
var btn = document.getElementById("botao");
var btn2 = document.getElementById("sair");
var esconde = 'esconde';


var form1 = document.querySelector("#form1");
var modal = document.querySelector("#modal");
var cpf2 = document.querySelector("#cpf2");
var nome2 = document.querySelector("#nome2");
var sobrenome2 = document.querySelector("#sobrenome2");
var email1 = document.querySelector("#email");
var email2 = document.querySelector("#email2");
var datanascimento2 = document.querySelector("#datanascimento2");
var rg2 = document.querySelector("#rg2");
var sexo2 = document.querySelector("#sexo2");
var cep2 = document.querySelector("#cep2");
var endereco2 = document.querySelector("#endereco2");
var bairro2 = document.querySelector("#bairro2");
var complemento2 = document.querySelector("#complemento2");
var cidade2 = document.querySelector("#cidade2");
var uf2 = document.querySelector("#uf");
var celular2 = document.querySelector("#celular2");
var numero2 = document.querySelector("#numero2");





function selectestado() {

    let estados = [
        "AC",
        "AL",
        "AP",
        "AM",
        "BA",
        "CE",
        "DF",
        "ES",
        "GO",
        "MA",
        "MT",
        "MS",
        "MG",
        "PA",
        "PB",
        "PR",
        "PE",
        "PI",
        "RJ",
        "RN",
        "RS",
        "RO",
        "RR",
        "SC",
        "SP",
        "SE",
        "TO",];
    var uf2 = document.querySelector("#uf");
    for (var x = 0; x < estados.length; x++) {

        var option = document.createElement("option"),
            txt = document.createTextNode(estados[x]);

        option.appendChild(txt);
        option.setAttribute("value", estados[x]);
        uf2.insertBefore(option, estados.lastChild);


    }


}




//logica para verificar se existe erro
function verificarerro() {
    //let procurarerro = false;
    //const verifica = event.target;

    //busco somente required do formulário
    var somenteRequired = document.getElementById('form1').querySelectorAll("[required]");

    //monto a estrutura de repetição para varrer quem está valido ou não
    for (var i = 0; i <= somenteRequired.length; i++) {

        //por algum motivo(verificar no formulario ou na documentação) ta trazendo 9 elementos, sendo que 1 vem undefined que é equivalente a null
        //nesse caso valido para não estourar erro 
        if (somenteRequired[i] != undefined)
            if (!somenteRequired[i].validity.valid) { // aqui eu trago tudo que é falso (nota adicionei o '!' para negar se vier false, logo o que vier invalido eu falo que é valido para acionar o if == true)
               var botao1= document.querySelector("#botao");
            

            }
            else {

                validaemail()


            }

    }



}



function validaemail() {

    validaemail1 = form1.email.value;
    validaemail2 = form1.confirmaemail.value;

    var divmensagens = document.querySelector("#alerta");
    divmensagens.textContent = "";

    if (validaemail1 === validaemail2) {


        validasenha();

    }

    else {
        mensagens("E-MAIL não conferem: Tente novamente!");
    }

}





function mensagens(texto) {
    var msg = document.createElement("div");
    msg.classList.add("alerta");
    msg.textContent = texto;
    var divmensagens = document.querySelector("#alerta");
    divmensagens.appendChild(msg);


}

function validasenha() {
    var divmensagens = document.querySelector("#alerta");
    divmensagens.textContent = "";
    const validasenha1 = form1.senha.value;
    const validasenha2 = form1.senha2.value;


    if (validasenha1 === validasenha2) {
        conteiner.classList.add(esconde);

        cpf2.innerHTML = "CPF: " + form1.cpf.value;
        nome2.innerHTML = "Nome: " + form1.nome.value;
        sobrenome2.innerHTML = "SobreNome: " + form1.sobrenome.value;
        email2.innerHTML = "Email: " + form1.email.value;
        datanascimento2.innerHTML = "Data de Nascimento: " + form1.nascimento.value;
        rg2.innerHTML = "RG: " + form1.rg.value;
        sexo2.innerHTML = "Sexo: " + form1.sexo.value;
        cep2.innerHTML = "CEP: " + form1.cep.value;
        endereco2.innerHTML = "Endereço: " + form1.rua.value;
        bairro2.innerHTML = "Bairro: " + form1.bairro.value;
        numero2.innerHTML = "Número: " + form1.numero.value;
        complemento2.innerHTML = "Complemento: " + form1.complemento.value;
        cidade2.innerHTML = "Cidade: " + form1.cidade.value;
        uf2.innerHTML = "UF: " + form1.uf.value;
        celular2.innerHTML = "Celular: " + form1.celular.value;



        btn2.onclick = function () {
            conteiner.classList.remove(esconde);
        }
    }
    else {
        mensagens("As senhas não conferem: Tente novamente!");
    }



}



var senha = document.querySelector("#senha");
var senha2 = document.querySelector("#senha2");
var olho = document.querySelector("#olho");

function abreolho() {



    if (senha.type === 'password') {
        abre()
    }

    else {

        fecha()


    }


}


function abre() {
    senha.setAttribute("type", "text")
    senha2.setAttribute("type", "text")

}

function fecha() {
    senha.setAttribute("type", "password")
    senha2.setAttribute("type", "password")

}

/*function verde(){

    if(isNaN(form1.nome.value) ==true){
form1.nome.classList.add('xx');
    }
    else{
        form1.nome.value='';
        form1.focus();
        form1.nome.classList.add('xy');
        form1.nome("blur");

    }
}
*/


/*botao.onclick = function(event){
    event.preventDefault();


    
}
*/


/*conteiner.classList.add(esconde);

                cpf2.innerHTML = "CPF: " + form1.cpf.value;
                nome2.innerHTML = "Nome: " + form1.nome.value;
                sobrenome2.innerHTML = "SobreNome: " + form1.sobrenome.value;
                email2.innerHTML = "Email: " + form1.email.value;
                datanascimento2.innerHTML = "Data de Nascimento: " + form1.nascimento.value;
                rg2.innerHTML = "RG: " + form1.rg.value;
                sexo2.innerHTML = "Sexo: " + form1.sexo.value;
                cep2.innerHTML = "CEP: " + form1.cep.value;
                endereco2.innerHTML = "Endereço: " + form1.rua.value;
                bairro2.innerHTML = "Bairro: " + form1.bairro.value;
                numero2.innerHTML = "Número: " + form1.numero.value;
                complemento2.innerHTML = "Complemento: " + form1.complemento.value;
                cidade2.innerHTML = "Cidade: " + form1.cidade.value;
                uf2.innerHTML = "UF: " + form1.uf.value;
                celular2.innerHTML = "Celular: " + form1.celular.value;



btn2.onclick = function () { conteiner.classList.remove(esconde); }

*/
