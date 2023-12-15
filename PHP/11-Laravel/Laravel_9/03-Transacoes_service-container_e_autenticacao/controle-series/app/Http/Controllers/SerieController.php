<?php

namespace App\Http\Controllers;

use App\Http\Requests\SeriesFormRequest;
use App\Models\Episode;
use App\Models\Season;
use App\Models\Series;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class SerieController extends Controller
{

    public function index()
    {
        $series = Series::query()->get();

        return view("series.index")->with('series', $series);
    }


    public function create()
    {
        return view("series.create");
    }


    public function store(SeriesFormRequest $request)
    {
        $serie = DB::transaction(function () use ($request) {
            $serie = Series::create($request->all());
            $seasons = [];
            for($i = 1; $i <= $request->seasonsQty; $i++) {
                $seasons[] = [
                    'series_id' => $serie->id,
                    'number' => $i
                ];
            }
            Season::insert($seasons);

            $episodes = [];
            foreach ($serie->seasons as $season) {
                for ($j = 1; $j <= $request->episodesPerSeason; $j++) {
                    $episodes[] = [
                        'season_id' => $season->id,
                        'number' => $j
                    ];
                }
            }
            Episode::insert($episodes);

            return $serie;
        });

        return to_route('series.index')->with('mensagem', "Série '$serie->nome' criada com sucesso!");
    }

    /**
     * Display the specified resource.
     *
     * @param  \App\Models\Series  $serie
     * @return \Illuminate\Http\Response
     */
    public function show(Series $serie)
    {
        //
    }


    public function edit(Series $series)
    {
        return view('series.edit')->with('serie', $series);
    }


    public function update(Series $series, Request $request)
    {
        $series->fill($request->all());
        $series->save();

        return to_route('series.index')->with('mensagem', "Série '$request->nome' editada com sucesso!");
    }


    public function destroy(Series $series)
    {
        $series->delete();

        return to_route('series.index')->with('mensagem', "Série '$series->nome' excluída com sucesso!");
    }
}
