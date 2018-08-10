function apagarElemento(id) {
    if (document.contains(document.getElementById(id))) {
        document.getElementById(id).remove();
    }
}

function validarFormulario() {
    var textoCampoCodigoMatricula = document.getElementById("campo-codigo-matricula").value;
    var textoCampoNota1 = document.getElementById("campo-nota-1").value;
    var textoCampoNota2 = document.getElementById("campo-nota-2").value;
    var textoCampoNota3 = document.getElementById("campo-nota-3").value;
    var textoCampoFrequencia = document.getElementById("campo-frequencia").value;

    if (validarCampoNome() == false) {
        event.preventDefault();
    }
}

function validarCampoNome() {
    var textoCampoNome = document.getElementById("campo-nome").value;

    document.getElementById("campo-nome").classList.remove("border-success");

    apagarElemento("span-campo-nome-menor-7");
    apagarElemento("span-campo-nome-maior-100");

    if (textoCampoNome.length < 7) {
        var elementSpanNome = document.createElement("span");
        var text = document.createTextNode("Nome deve ter no mínimo 7 caracteres");
        elementSpanNome.id = "span-campo-nome-menor-7";
        elementSpanNome.appendChild(text);
        elementSpanNome.classList.add("text-danger");
        document.getElementById("div-campo-nome").appendChild(elementSpanNome);
        document.getElementById("campo-nome").classList.add("border-danger");
        return false;

    }

    if (textoCampoNome.length > 100) {
        var elementSpanNome = document.createElement("span");
        elementSpanNome.textContent = "Nome deve conter no máximo 100 caracteres";
        elementSpanNome.id = "span-campo-nome-maior-100";
        elementSpanNome.classList.add("text-danger");
        document.getElementById("div-campo-nome").appendChild(elementSpanNome);
        document.getElementById("campo-nome").classList.add("border-danger");
        return false;
    }

    if (textoCampoNome.length >= 7 && textoCampoNome.length <= 100) {
        document.getElementById("campo-nome").classList.remove("border-danger");
        document.getElementById("campo-nome").classList.add("border-success");
        return true;

    }
}

function validarCampoCodigoMatricula() {
    var textoCodigoMatricula = document.getElementById("campo-codigo-matricula").value;
    document.getElementById("campo-codigo-matricula").classList.remove("border-success");

    apagarElemento("span-campo-codigo-matricula");

    if ((textoCodigoMatricula.length > 20) || (textoCodigoMatricula.length == 0)) {
        var elementSpanCodigoMatricula = document.createElement("span");
        var text = document.createTextNode("Informe um código de Matricula válido");
        elementSpanCodigoMatricula.id = "span-campo-codigo-matricula";
        elementSpanCodigoMatricula.appendChild(text);
        elementSpanCodigoMatricula.classList.add("text-danger");
        document.getElementById("div-campo-codigo-matricula").appendChild(elementSpanCodigoMatricula);
        document.getElementById("campo-codigo-matricula").classList.add("border-danger");
        return false;
    }

    if ((textoCodigoMatricula.length < 20) && (textoCodigoMatricula.length > 0)) {
        document.getElementById("campo-codigo-matricula").classList.remove("border-danger");
        document.getElementById("campo-codigo-matricula").classList.add("border-success");
        return true;

    }
}

function validarNota1() {
    var textoNota1 = document.getElementById("campo-nota-1").value;
    document.getElementById("campo-nota-1").classList.remove("border-success");

    apagarElemento("span-campo-nota-1");

    if  (textoNota1.length == 0)  {
        var elementSpanNota1 = document.createElement("span");
        var text = document.createTextNode("Informe uma nota válida");
        elementSpanNota1.id = "span-campo-nota-1";
        elementSpanNota1.appendChild(text);
        elementSpanNota1.classList.add("text-danger");
        document.getElementById("div-campo-nota-1").appendChild(elementSpanNota1);
        document.getElementById("campo-nota-1").classList.add("border-danger");
        return false;
    }

    if  (textoNota1.length != 0) {
        document.getElementById("campo-nota-1").classList.remove("border-danger");
        document.getElementById("campo-nota-1").classList.add("border-success");
        return true;
    }
}

function validarNota2() {
    var textoNota2 = document.getElementById("campo-nota-2").value;
    document.getElementById("campo-nota-2").classList.remove("border-success");

    apagarElemento("span-campo-nota-2");

    if (textoNota2.length == 0) {
        var elementSpanNota2 = document.createElement("span");
        var text = document.createTextNode("Informe uma nota válida");
        elementSpanNota2.id = "span-campo-nota-2";
        elementSpanNota2.appendChild(text);
        elementSpanNota2.classList.add("text-danger");
        document.getElementById("div-campo-nota-2").appendChild(elementSpanNota2);
        document.getElementById("campo-nota-2").classList.add("border-danger");
        return false;
    }

    if (textoNota2.length != 0) {
        document.getElementById("campo-nota-2").classList.remove("border-danger");
        document.getElementById("campo-nota-2").classList.add("border-success");
        return true;
    }
}

function validarNota3() {
    var textoNota3 = document.getElementById("campo-nota-3").value;
    document.getElementById("campo-nota-3").classList.remove("border-success");

    apagarElemento("span-campo-nota-3");

    if (textoNota3.length == 0) {
        var elementSpanNota3 = document.createElement("span");
        var text = document.createTextNode("Informe uma nota válida");
        elementSpanNota3.id = "span-campo-nota-3";
        elementSpanNota3.appendChild(text);
        elementSpanNota3.classList.add("text-danger");
        document.getElementById("div-campo-nota-3").appendChild(elementSpanNota3);
        document.getElementById("campo-nota-3").classList.add("border-danger");
        return false;
    }

    if (textoNota3.length != 0) {
        document.getElementById("campo-nota-3").classList.remove("border-danger");
        document.getElementById("campo-nota-3").classList.add("border-success");
        return true;
    }
}

function validarFrequencia() {
    var textoFrequencia = document.getElementById("campo-nota-3").value;
    document.getElementById("campo-frequencia").classList.remove("border-success");

    apagarElemento("span-campo-frequencia");

    if (textoFrequencia.length == 0) {
        var elementSpanFrequencia = document.createElement("span");
        var text = document.createTextNode("Informe uma frequência válida");
        elementSpanFrequencia.id = "span-campo-frequencia";
        elementSpanFrequencia.appendChild(text);
        elementSpanFrequencia.classList.add("text-danger");
        document.getElementById("div-campo-frequencia").appendChild(elementSpanFrequencia);
        document.getElementById("campo-frequencia").classList.add("border-danger");
        return false;
    }

    if (textoFrequencia.length != 0) {
        document.getElementById("campo-frequencia").classList.remove("border-danger");
        document.getElementById("campo-frequencia").classList.add("border-success");
        return true;
    }
}