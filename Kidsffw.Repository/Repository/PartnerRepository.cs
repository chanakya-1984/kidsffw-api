using Kidsffw.Contracts.Interfaces;
using Kidsffw.Models;
using Kidsffw.Models.DTO;
using Kidsffw.Repository.Interface;
using Microsoft.Azure.Cosmos;

namespace Kidsffw.Repository.Repository;

public class PartnerRepository : IPartnerRepository
{
    private readonly Container _container;
    
    private const string ContainerName = "partners";

    public PartnerRepository(ICosmosContainer container)
    {
        _container = container.GetCosmosContainer(ContainerName);
    }
    
    public IAsyncEnumerable<Partner> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Partner> GetByPartitionKeyAsync(string partitionKey)
    {
        throw new NotImplementedException();
    }

    public async Task<Partner> AddAsync(Partner entity)
    {
        var result = await _container.CreateItemAsync(entity);
        return result;
    }

    public Task<Partner> UpdateAsync(Partner entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Partner entity)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<RegistrationCoupon> GetRegistrationCouponsByPartnerPhoneNumber(string phoneNumber, bool onlyActive = true)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetDiscountPercentageByCouponCode(string couponCode, bool onlyActive = true)
    {
        throw new NotImplementedException();
    }

    public Task AddNewRegistrationCoupon(RegistrationCoupon registrationCoupon, string partnerPhoneNumber)
    {
        throw new NotImplementedException();
    }

    public Task UpdateRegistrationCoupon(RegistrationCoupon registrationCoupon)
    {
        throw new NotImplementedException();
    }

    public Task DisableRegistrationCoupon(string couponCode)
    {
        throw new NotImplementedException();
    }

    public Task<PartnerContact> GetPartnerContactInformationByCouponId(int couponId)
    {
        throw new NotImplementedException();
    }
}