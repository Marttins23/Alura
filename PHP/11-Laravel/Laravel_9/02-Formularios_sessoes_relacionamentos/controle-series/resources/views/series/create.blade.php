<x-template title="Nova Série">
    <form action="{{ route('series.store') }}" method="post">
        @csrf
        <div class="row mb-3">
            <div class="col-8">
                <label for="nome">Nome da Série</label>
                <input type="text"
                       autofocus
                       class="form-control"
                       name="nome" id="nome"
                       value="{{ old('nome') }}"
                >
            </div>
            <div class="col-2">
                <label for="seasonsQty"> N° Temporadas</label>
                <input type="number"
                       class="form-control"
                       name="seasonsQty" id="seasonsQty"
                       value="{{ old('seasonsQty') }}"
                >
            </div>
            <div class="col-2">
                <label for="episodesPerSeason">Eps / Temporada</label>
                <input type="number"
                       class="form-control"
                       name="episodesPerSeason" id="episodesPerSeason"
                       value="{{ old('episodesPerSeason') }}"
                >
            </div>
        </div>

        <button type="submit" class="btn btn-primary">Salvar</button>
    </form>
</x-template>
