// Fill out your copyright notice in the Description page of Project Settings.


#include "SimVizPlayerController.h"

void ASimVizPlayerController::BeginPlay()
{
    Super::BeginPlay();
    SetInputMode(FInputModeGameAndUI());
}
