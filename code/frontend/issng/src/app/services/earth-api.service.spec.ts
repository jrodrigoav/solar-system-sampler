import { TestBed } from '@angular/core/testing';

import { EarthApiService } from './earth-api.service';

describe('EarthApiService', () => {
  let service: EarthApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(EarthApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
