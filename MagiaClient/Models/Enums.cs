namespace MagiaClient.Models;

using System;

public enum ObjectObjectType
{
    Gem = 1,
    Card = 2,
    Item = 3,
    Character = 4,
    Style = 5,
    Adv = 6,
    Gold = 7,
    Talisman = 8,
    Enemy = 9,
    DioramaBackground = 10,
    ChargeGem = 11,
    UserTitle = 12,
    Sound = 13,
    UserExp = 14,
    KiokuHikari = 999,
}

public enum QuestBattleResult
{
    Init = -1,
    None = 0,
    Win = 1,
    Lose = 2,
    Timeout = 3,
    Retire = 4,
    Skip = 5,
}

public enum GachaGachaType
{
    Normal = 1,
    StepUp = 2,
    StartDash = 3,
    Comeback = 4,
    Tutorial = 5,
}

public enum GachaGachaDrawType
{
    Normal = 1,
    StepUp = 2,
    Tutorial = 3,
}

