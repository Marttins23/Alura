<x-template title="Nova Série">
    <form action="{{ route('series.store') }}" method="post">
        @csrf
        <div class="form-group">
            <label for="nome">Nome da Série</label>
            <input type="text" class="form-control" name="nome" id="nome">
        </div>

        <button type="submit" class="btn btn-primary">Adicionar</button>
    </form>
</x-template>
