﻿namespace DO;
/// <summary>
/// Student Entity represents an engineer with all its props
/// </summary>
/// <param name="Id">Personal unique ID of engineer (as in national id card)</param>
/// <param name="Name">engineer's name</param>
/// <param name="Email">engineer's email adrres</param>
/// <param name="Level">engineer's level can either be a manager or engineer</param>
/// <param name="Wage">salary per hour</param>
public record Engineer
(
   int Id,
   string Name,
   string Email,
   EngineerExperience Level,
   int Wage
);
 

 