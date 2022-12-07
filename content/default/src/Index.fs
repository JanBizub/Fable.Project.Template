module Index

open Elmish

type Model = { Todos: string list; Input: string }

type Msg =
    | GotTodos of string list
    | SetInput of string

let init () : Model * Cmd<Msg> =
    let model = { Todos = []; Input = "" }
    model, Cmd.none

let update (msg: Msg) (model: Model) : Model * Cmd<Msg> =
    match msg with
    | GotTodos todos -> { model with Todos = todos }, Cmd.none
    | SetInput value -> { model with Input = value }, Cmd.none

open Feliz
let view (model: Model) (dispatch: Msg -> unit) =
    Html.div [
        Html.p "Fable App"
    ]