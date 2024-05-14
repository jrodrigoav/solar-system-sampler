import { Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { AboutComponent } from './pages/about/about.component';
import { PageNotFoundComponent } from './pages/page-not-found/page-not-found.component';
import { SunComponent } from './pages/sun/sun.component';
import { EarthComponent } from './pages/earth/earth.component';

export const routes: Routes = [
    { path: 'home', component: HomeComponent  },
    { path: 'sun', component: SunComponent  },
    { path: 'earth', component: EarthComponent  },
    { path: 'about', component: AboutComponent  },
    { path: '', redirectTo: '/home', pathMatch: 'full' },
    { path: '**', component: PageNotFoundComponent }
];
