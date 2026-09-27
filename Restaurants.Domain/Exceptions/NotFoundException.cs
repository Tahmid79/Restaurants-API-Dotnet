namespace Restaurants.Domain.Exceptions;

public class NotFoundException(string resourceType, string resourceId):
    Exception($"{resourceType} with id: {resourceId} does not exist")
{

}
