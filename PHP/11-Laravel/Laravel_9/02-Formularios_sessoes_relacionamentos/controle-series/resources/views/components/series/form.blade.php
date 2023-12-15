<form action="{{ $action }}" method="post">
    @csrf
    @if($update)
        @method('PUT')
    @endif
    <div class="form-group">
        <label for="nome">Nome da Série</label>
        <input type="text"
               class="form-control"
               name="nome" id="nome"
               @isset($nome)
                   value="{{ $nome }}"
               @endisset
        >
    </div>

    <button type="submit" class="btn btn-primary">Salvar</button>
</form>
