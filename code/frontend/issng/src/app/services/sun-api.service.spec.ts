import { TestBed } from '@angular/core/testing';

import { SunApiService } from './sun-api.service';

describe('SunApiService', () => {
  let service: SunApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SunApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
