module Libreria

open Newtonsoft.Json
type Persona = { Nome : string; Idade : int} //definindo un record
let getPersona() =
    let texto = """{ "Nome": "Suso", "Idade" : 18 }""" //Texto sample en JSON que se corresponde coa estructura do noso record
    let persona = JsonConvert.DeserializeObject<Persona>(texto) //Usando Newtonsoft para deserializar o obxeto
    printfn "O teu nome e %s e tes %d anos" persona.Nome persona.Idade
    persona