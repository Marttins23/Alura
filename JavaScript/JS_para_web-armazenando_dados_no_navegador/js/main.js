const form = $('#novoItem');

form.on('submit', (evento) => {
    evento.preventDefault();

    criaElemento($('#nome').val(), $('#quantidade').val());
});

function criaElemento(nome, quantidade) {
    $('.lista').append('li').addClass('item').html(quantidade);
}