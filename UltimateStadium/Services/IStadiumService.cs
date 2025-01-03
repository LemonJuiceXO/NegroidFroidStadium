using BlazorApp1.Domain;

namespace UltimateStadium.Services;

public interface IStadiumService
{
    public Task<List<Stadium>> getAllStadiums();

    public Task<bool> addNewStadium(string stadiumName,string stadiumPlace,double stadiumPrice);
}