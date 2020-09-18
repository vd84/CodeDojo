using Models;
namespace Repos
{
  internal interface IResponsRepo
  {
    public ResponsModel GetResponsibleForArende(int id);
  }
}