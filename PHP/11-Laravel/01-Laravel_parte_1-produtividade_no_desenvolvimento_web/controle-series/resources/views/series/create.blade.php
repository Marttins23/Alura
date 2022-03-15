@extends('layout')

@section('cabecalho')
    Adicionar Série
@endsection

@section('conteudo')
    @if ($errors->any())
        <div class="alert alert-danger">
            <ul>
                @foreach ($errors->all() as $error)
                    <li>{{ $error }}</li>
                @endforeach
            </ul>
        </div>
    @endif
    <form action="{{ route('series.store') }}" method="post">
        @csrf
        <div class="form-group">
            <label for="nome">Nome da Série</label>
            <input type="text" class="form-control" name="nome" id="nome">
        </div>

        <button type="submit" class="btn btn-primary">Adicionar</button>
    </form>
@endsection
