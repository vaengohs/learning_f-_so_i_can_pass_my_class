module AnnalynsInfiltration

let canFastAttack (knightIsAwake: bool): bool = 
    not knightIsAwake

let canSpy (knightIsAwake: bool) (archerIsAwake: bool) (prisonerIsAwake: bool): bool =
    knightIsAwake || archerIsAwake || prisonerIsAwake 

let canSignalPrisoner (archerIsAwake: bool) (prisonerIsAwake: bool): bool =
    if prisonerIsAwake && not archerIsAwake then true else false 

let canFreePrisoner (knightIsAwake: bool) (archerIsAwake: bool) (prisonerIsAwake: bool) (petDogIsPresent: bool): bool = 
    if petDogIsPresent && not archerIsAwake then 
        true 
    elif not petDogIsPresent && prisonerIsAwake && not knightIsAwake && not archerIsAwake then 
        true
    else 
        false