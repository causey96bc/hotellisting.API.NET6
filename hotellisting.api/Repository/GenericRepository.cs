﻿namespace hotellisting.api.Repository;
  
    
using hotellisting.api.Contracts;
using hotellisting.api.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly HotelListingDbContext _context;

    public GenericRepository(HotelListingDbContext context)
    {
        _context = context;
    }
    public async Task<T> AddAsync(T entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;  
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await GetAsync(id);
        _context.Set<T>().Remove(entity);
    }

    public async Task<bool> Exists(int id)
    {
       var entity = await GetAsync(id);
        return entity != null;
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await  _context.Set<T>().ToListAsync();
    }

    public async  Task<T> GetAsync(int? id)
    {
        if(id == null)
        {
            return null;
        }
        return await _context.Set<T>().FindAsync();    

    }

    public async Task UpdateAsync(T entity)

    {
        _context.Update(entity);
        await _context.SaveChangesAsync();
    }
}

