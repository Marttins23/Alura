<?php

namespace App\Http\Controllers;

use App\Models\Serie;
use App\Http\Requests\StoreSerieRequest;
use App\Http\Requests\UpdateSerieRequest;
use Illuminate\Http\Request;

class SerieController extends Controller
{

    public function index()
    {
        $series = Serie::query()->orderBy('nome')->get();

        return view("series.index")->with('series', $series);
    }


    public function create()
    {
        return view("series.create");
    }


    public function store(Request $request)
    {
        Serie::create($request->only('nome'));

        return to_route('series.index')->with('mensagem', "Série ' $request->nome ' criada com sucesso!");
    }

    /**
     * Display the specified resource.
     *
     * @param  \App\Models\Serie  $serie
     * @return \Illuminate\Http\Response
     */
    public function show(Serie $serie)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  \App\Models\Serie  $serie
     * @return \Illuminate\Http\Response
     */
    public function edit(Serie $serie)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \App\Http\Requests\UpdateSerieRequest  $request
     * @param  \App\Models\Serie  $serie
     * @return \Illuminate\Http\Response
     */
    public function update(UpdateSerieRequest $request, Serie $serie)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  \App\Models\Serie  $serie
     * @return \Illuminate\Http\Response
     */
    public function destroy(Serie $serie)
    {
        //
    }
}
