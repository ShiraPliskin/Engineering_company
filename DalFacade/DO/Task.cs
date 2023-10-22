﻿namespace DO;
/// <summary>
/// 
/// </summary>
/// <param name="Id">unique ID (created automatically)</param>
/// <param name="Description">describe the task</param>
/// <param name="Alias">The alias of the task</param>
/// <param name="StartDate">the real start date</param>
/// <param name="ScheduledDate">the original date on which it should be completed</param>
/// <param name="ForecastDate">a revised scheduled completion date</param>
/// <param name="EngineerId"></param>
/// <param name="CopmlexityLevel">task: minimum expirience for engineer to assign</param>
/// <param name="IsMilestone"></param>
public record Task
(
    int Id,
    string Description,
    string Alias,
    DateTime StartDate,
    DateTime ScheduledDate,
    DateTime ForecastDate,
    int EngineerId,
    EngineerExperience CopmlexityLevel,
    bool IsMilestone = false
)
{
    DateTime CreatedAtDate => DateTime.Now;//ate when the task was added to the system, get only
    DateTime CompleteDate;//real completion date.
    string Deliverables;//description of deliverables for MS copmletion.
    string Remarks;//free remarks from project meetings.
}