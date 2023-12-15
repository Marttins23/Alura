<x-template title="Series">
    <a href="{{ route('series.create') }}" class="btn btn-dark mb-2">Adicionar</a>
    <ul class="list-group">
        @foreach($series as $serie)
            <li class="list-group-item d-flex justify-content-between align-items-center">
                <a href="{{ route('seasons.index', $serie->id) }}">
                    {{ $serie->nome }}
                </a>

                <span class="d-flex">
                    <a href="{{ route('series.edit', $serie->id) }}" class="btn btn-info btn-sm mr-1" title="Editar">
                        <i class="fa-solid fa-arrow-up-right-from-square"></i>
                    </a>
                    <form name="formDelete"
                          action="{{ route('series.destroy', $serie->id) }}"
                          method="post"
                          onsubmit="return confirm('Deseja realmente excluir a Série?');">
                        @csrf
                        @method("DELETE")
                        <button type="submit" class="btn btn-danger btn-sm" title="Excluir">
                            <i class="fa-solid fa-trash-can"></i>
                        </button>
                    </form>
                </span>

            </li>
        @endforeach
    </ul>
</x-template>
