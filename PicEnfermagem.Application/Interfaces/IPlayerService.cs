﻿using PicEnfermagem.Application.DTOs.Insert;

namespace PicEnfermagem.Application.Interfaces;

public interface IPlayerService
{
    Task<bool> InsertPlayer(PlayerInsertRequest player);
}
