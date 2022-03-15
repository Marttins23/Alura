<?php

namespace App\Http\Controllers;

use App\Http\Requests\SeriesFormRequest;
use App\Models\Serie;
use Illuminate\Http\RedirectResponse;
use Illuminate\Http\Request;

class SeriesController extends Controller
{
    public function index(Request $request)
    {
        $series = Serie::query()
            ->orderBy('nome')
            ->get();

        return view('series.index', compact('series'));
    }

    public function create(Request $request)
    {
        return view('series.create');
    }

    public function store(SeriesFormRequest $request)
    {
        $serie = Serie::create($request->all());

        $mensagem = "Série {$serie->id} adicionada com sucesso: {$serie->nome}";

        $request->session()->flash('mensagem', $mensagem);

        return redirect()->route('series.index');
    }


    public function destroy(int $id)
    {
        Serie::destroy($id);

        $mensagem = "Série removida com sucesso!";

        session()->flash('mensagem', $mensagem);

        return redirect()->route('series.index');
    }
}
