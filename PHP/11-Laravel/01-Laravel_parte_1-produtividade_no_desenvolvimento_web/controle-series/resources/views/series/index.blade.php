@extends('layout')

@section('cabecalho')
    Séries
@endsection

@section('conteudo')
@if(session('mensagem'))
    <div class="alert alert-success">
        {{ session('mensagem') }}
    </div>
@endif
    <a href="{{ route('series.create') }}" class="btn btn-dark mb-2">Adicionar</a>
    <ul class="list-group">
        @foreach($series as $serie)
            <li class="list-group-item d-flex justify-content-between align-items-center">
                {{ $serie->nome }}
                <form name="formDelete"
                      action="{{ route('series.destroy', $serie->id) }}"
                      method="post"
                      onsubmit="return confirm('Deseja realmente excluir a Série?');">
                    @csrf
                    @method("DELETE")
                    <button type="submit" class="btn btn-danger btn-sm">
                        <i class="fa-solid fa-trash-can"></i>
                    </button>
                </form>
            </li>
        @endforeach
    </ul>
@endsection
